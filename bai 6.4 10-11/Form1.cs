using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GarageManagementSystem
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối đến LocalDB trong Visual Studio
        // Nếu dùng SQL Server riêng, hãy đổi Data Source tương ứng
        private string strCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GarageDB;Integrated Security=True";

        // Bảng tạm để lưu danh sách phụ tùng người dùng chọn trước khi bấm Lưu phiếu
        private DataTable dtTam = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoBangTam();
            LoadDanhSachPhuTung();
        }

        private void KhoiTaoBangTam()
        {
            dtTam.Columns.Clear();
            dtTam.Columns.Add("MaPhuTung", typeof(int));
            dtTam.Columns.Add("TenPhuTung", typeof(string));
            dtTam.Columns.Add("SoLuong", typeof(int));
            dtTam.Columns.Add("DonGia", typeof(decimal));
            dtTam.Columns.Add("TienCong", typeof(decimal));
            dtTam.Columns.Add("ThanhTien", typeof(decimal));

            dgvChiTiet.DataSource = dtTam;
        }

        private void LoadDanhSachPhuTung()
        {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT MaPhuTung, TenPhuTung, DonGia, SoLuongTon FROM PhuTung";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboPhuTung.DataSource = dt;
                    cboPhuTung.DisplayMember = "TenPhuTung";
                    cboPhuTung.ValueMember = "MaPhuTung";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải phụ tùng: " + ex.Message);
                }
            }
        }

        // ==========================================
        // 1. TIẾP NHẬN XE & QUẢN LÝ CHỦ XE
        // ==========================================
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string bienSo = txtBienSo.Text.Trim();
            if (string.IsNullOrEmpty(bienSo))
            {
                MessageBox.Show("Vui lòng nhập biển số xe để tra cứu!", "Thông báo");
                return;
            }

            using (SqlConnection con = new SqlConnection(strCon))
            {
                // Sử dụng SqlParameter để tránh SQL Injection
                string query = @"SELECT x.BienSo, x.HieuXe, x.NamSanXuat, k.TenKH, k.DienThoai, k.DiaChi 
                                 FROM Xe x 
                                 JOIN KhachHang k ON x.MaKH = k.MaKH 
                                 WHERE x.BienSo = @BienSo";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@BienSo", SqlDbType.VarChar, 20).Value = bienSo;

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTenKH.Text = reader["TenKH"].ToString();
                        txtDienThoai.Text = reader["DienThoai"].ToString();
                        txtDiaChi.Text = reader["DiaChi"].ToString();
                        txtHieuXe.Text = reader["HieuXe"].ToString();
                        numNamSX.Value = Convert.ToInt32(reader["NamSanXuat"]);

                        MessageBox.Show("Đã tìm thấy thông tin xe và chủ xe!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Xe mới chưa có trong hệ thống! Xin hãy nhập thông tin chủ xe và xe rồi bấm 'Tiếp nhận/Lưu Xe'.", "Thông báo");
                        txtTenKH.Clear();
                        txtDienThoai.Clear();
                        txtDiaChi.Clear();
                        txtHieuXe.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnLuuXe_Click(object sender, EventArgs e)
        {
            string bienSo = txtBienSo.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string sdt = txtDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string hieuXe = txtHieuXe.Text.Trim();
            int namSX = (int)numNamSX.Value;

            if (string.IsNullOrEmpty(bienSo) || string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập ít nhất Biển số xe và Tên chủ xe!");
                return;
            }

            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                try
                {
                    // 1. Thêm khách hàng nếu chưa có (dựa vào số điện thoại)
                    string sqlKH = @"IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE DienThoai = @DienThoai)
                                     BEGIN
                                         INSERT INTO KhachHang (TenKH, DienThoai, DiaChi) 
                                         VALUES (@TenKH, @DienThoai, @DiaChi);
                                         SELECT SCOPE_IDENTITY();
                                     END
                                     ELSE
                                     BEGIN
                                         SELECT MaKH FROM KhachHang WHERE DienThoai = @DienThoai;
                                     END";

                    SqlCommand cmdKH = new SqlCommand(sqlKH, con, trans);
                    cmdKH.Parameters.AddWithValue("@TenKH", tenKH);
                    cmdKH.Parameters.AddWithValue("@DienThoai", sdt);
                    cmdKH.Parameters.AddWithValue("@DiaChi", diaChi);

                    int maKH = Convert.ToInt32(cmdKH.ExecuteScalar());

                    // 2. Thêm xe
                    string sqlXe = @"IF NOT EXISTS (SELECT 1 FROM Xe WHERE BienSo = @BienSo)
                                     BEGIN
                                         INSERT INTO Xe (BienSo, MaKH, HieuXe, NamSanXuat)
                                         VALUES (@BienSo, @MaKH, @HieuXe, @NamSanXuat)
                                     END";
                    SqlCommand cmdXe = new SqlCommand(sqlXe, con, trans);
                    cmdXe.Parameters.AddWithValue("@BienSo", bienSo);
                    cmdXe.Parameters.AddWithValue("@MaKH", maKH);
                    cmdXe.Parameters.AddWithValue("@HieuXe", hieuXe);
                    cmdXe.Parameters.AddWithValue("@NamSanXuat", namSX);
                    cmdXe.ExecuteNonQuery();

                    trans.Commit();
                    MessageBox.Show("Tiếp nhận xe và lưu thông tin thành công!");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message);
                }
            }
        }

        // ==========================================
        // 2. CHỌN DỊCH VỤ / PHỤ TÙNG VÀO BẢNG TẠM
        // ==========================================
        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (cboPhuTung.SelectedValue == null) return;

            int maPT = (int)cboPhuTung.SelectedValue;
            DataRowView rowView = (DataRowView)cboPhuTung.SelectedItem;
            string tenPT = rowView["TenPhuTung"].ToString();
            decimal donGia = Convert.ToDecimal(rowView["DonGia"]);

            int sl = (int)numSoLuong.Value;
            decimal tienCong = 0;
            decimal.TryParse(txtTienCong.Text, out tienCong);

            decimal thanhTien = (sl * donGia) + tienCong;

            // Kiểm tra xem đã thêm phụ tùng này vào danh sách tạm chưa
            foreach (DataRow r in dtTam.Rows)
            {
                if ((int)r["MaPhuTung"] == maPT)
                {
                    MessageBox.Show("Phụ tùng này đã có trong danh sách! Hãy xóa đi chọn lại.");
                    return;
                }
            }

            dtTam.Rows.Add(maPT, tenPT, sl, donGia, tienCong, thanhTien);
            TinhTongTienTam();
        }

        private void TinhTongTienTam()
        {
            decimal tong = 0;
            foreach (DataRow r in dtTam.Rows)
            {
                tong += Convert.ToDecimal(r["ThanhTien"]);
            }
            lblTongTien.Text = tong.ToString("N0") + " VNĐ";
        }

        // ==========================================
        // 3. LẬP PHIẾU VỚI SQLTRANSACTION (Cốt lõi)
        // ==========================================
        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            string bienSo = txtBienSo.Text.Trim();
            string noiDung = txtNoiDungSua.Text.Trim();

            if (string.IsNullOrEmpty(bienSo))
            {
                MessageBox.Show("Vui lòng nhập biển số xe cần sửa!");
                return;
            }

            if (dtTam.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất 1 phụ tùng / công sửa chữa!");
                return;
            }

            decimal tongTien = 0;
            foreach (DataRow r in dtTam.Rows) tongTien += Convert.ToDecimal(r["ThanhTien"]);

            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                // BẮT ĐẦU TRANSACTION ĐẢM BẢO TÍNH TOÀN VẸN
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    // Bước 1: Tạo bản ghi PhieuSuaChua
                    string sqlPhieu = @"INSERT INTO PhieuSuaChua (BienSo, NoiDungSua, TongTien, TrangThai) 
                                        VALUES (@BienSo, @NoiDung, @TongTien, N'Đang sửa');
                                        SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdPhieu = new SqlCommand(sqlPhieu, con, trans);
                    cmdPhieu.Parameters.AddWithValue("@BienSo", bienSo);
                    cmdPhieu.Parameters.AddWithValue("@NoiDung", noiDung);
                    cmdPhieu.Parameters.AddWithValue("@TongTien", tongTien);

                    int maPhieuMoi = Convert.ToInt32(cmdPhieu.ExecuteScalar());

                    // Duyệt từng phụ tùng trong danh sách
                    foreach (DataRow r in dtTam.Rows)
                    {
                        int maPT = Convert.ToInt32(r["MaPhuTung"]);
                        int soLuongCan = Convert.ToInt32(r["SoLuong"]);
                        decimal tienCong = Convert.ToDecimal(r["TienCong"]);

                        // Bước 2: Kiểm tra số lượng tồn kho của phụ tùng
                        string sqlCheckKho = "SELECT SoLuongTon FROM PhuTung WHERE MaPhuTung = @MaPhuTung";
                        SqlCommand cmdCheck = new SqlCommand(sqlCheckKho, con, trans);
                        cmdCheck.Parameters.AddWithValue("@MaPhuTung", maPT);

                        int slTonHienTai = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (slTonHienTai < soLuongCan)
                        {
                            // Ném Exception để nhảy vào khối Catch -> Rollback Transaction
                            throw new Exception($"Phụ tùng '{r["TenPhuTung"]}' không đủ hàng trong kho (Còn tồn: {slTonHienTai}, Yêu cầu: {soLuongCan})!");
                        }

                        // Bước 3: Trừ số lượng tồn kho
                        string sqlTruKho = "UPDATE PhuTung SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaPhuTung = @MaPhuTung";
                        SqlCommand cmdTru = new SqlCommand(sqlTruKho, con, trans);
                        cmdTru.Parameters.AddWithValue("@SoLuong", soLuongCan);
                        cmdTru.Parameters.AddWithValue("@MaPhuTung", maPT);
                        cmdTru.ExecuteNonQuery();

                        // Bước 4: Lưu vào bảng ChiTietSuaChua
                        string sqlCT = @"INSERT INTO ChiTietSuaChua (MaPhieu, MaPhuTung, SoLuong, TienCong)
                                         VALUES (@MaPhieu, @MaPhuTung, @SoLuong, @TienCong)";
                        SqlCommand cmdCT = new SqlCommand(sqlCT, con, trans);
                        cmdCT.Parameters.AddWithValue("@MaPhieu", maPhieuMoi);
                        cmdCT.Parameters.AddWithValue("@MaPhuTung", maPT);
                        cmdCT.Parameters.AddWithValue("@SoLuong", soLuongCan);
                        cmdCT.Parameters.AddWithValue("@TienCong", tienCong);
                        cmdCT.ExecuteNonQuery();
                    }

                    // Nếu tất cả các bước thành công -> COMMIT
                    trans.Commit();
                    MessageBox.Show($"Lập phiếu sửa chữa thành công! Mã phiếu của bạn là: {maPhieuMoi}", "Thành công");

                    // Reset form
                    dtTam.Rows.Clear();
                    txtNoiDungSua.Clear();
                    lblTongTien.Text = "0 VNĐ";
                    txtMaPhieuThanhToan.Text = maPhieuMoi.ToString();
                    LoadDanhSachPhuTung(); // Load lại để cập nhật tồn kho mới
                }
                catch (Exception ex)
                {
                    // Có lỗi xảy ra -> ROLLBACK lại toàn bộ thay đổi
                    trans.Rollback();
                    MessageBox.Show("GIAO DỊCH THẤT BẠI: " + ex.Message, "Lỗi Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // 4. THANH TOÁN PHIẾU SỬA CHỮA
        // ==========================================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaPhieuThanhToan.Text, out int maPhieu))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu sửa chữa hợp lệ để thanh toán!");
                return;
            }

            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
                {
                    con.Open();
                    // Lấy thông tin phiếu và tính tổng tiền
                    string queryCheck = "SELECT TongTien, TrangThai FROM PhieuSuaChua WHERE MaPhieu = @MaPhieu";
                    SqlCommand cmdCheck = new SqlCommand(queryCheck, con);
                    cmdCheck.Parameters.AddWithValue("@MaPhieu", maPhieu);

                    using (SqlDataReader rd = cmdCheck.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            string trangThai = rd["TrangThai"].ToString();
                            decimal tongTien = Convert.ToDecimal(rd["TongTien"]);

                            if (trangThai == "Đã thanh toán")
                            {
                                MessageBox.Show("Phiếu này đã được thanh toán trước đó rồi!");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã phiếu này!");
                            return;
                        }
                    }

                    // Cập nhật trạng thái
                    string sqlUpdate = "UPDATE PhieuSuaChua SET TrangThai = N'Đã thanh toán' WHERE MaPhieu = @MaPhieu";
                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, con);
                    cmdUpdate.Parameters.AddWithValue("@MaPhieu", maPhieu);
                    cmdUpdate.ExecuteNonQuery();

                    MessageBox.Show($"Thanh toán hóa đơn cho Phiếu số #{maPhieu} thành công!", "Xuất Hóa Đơn");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thanh toán: " + ex.Message);
                }
            }
        }
    }
}