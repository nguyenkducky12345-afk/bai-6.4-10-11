namespace GarageManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTiepNhan = new System.Windows.Forms.GroupBox();
            this.btnLuuXe = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.numNamSX = new System.Windows.Forms.NumericUpDown();
            this.txtHieuXe = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.lblNamSX = new System.Windows.Forms.Label();
            this.lblHieuXe = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblBienSo = new System.Windows.Forms.Label();
            this.gbDichVu = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.txtTienCong = new System.Windows.Forms.TextBox();
            this.lblTienCong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cboPhuTung = new System.Windows.Forms.ComboBox();
            this.lblPhuTung = new System.Windows.Forms.Label();
            this.gbPhieuSuaChua = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtMaPhieuThanhToan = new System.Windows.Forms.TextBox();
            this.lblMaPhieuTT = new System.Windows.Forms.Label();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTextTongTien = new System.Windows.Forms.Label();
            this.txtNoiDungSua = new System.Windows.Forms.TextBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.gbTiepNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNamSX)).BeginInit();
            this.gbDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.gbPhieuSuaChua.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTiepNhan
            // 
            this.gbTiepNhan.Controls.Add(this.btnLuuXe);
            this.gbTiepNhan.Controls.Add(this.btnTraCuu);
            this.gbTiepNhan.Controls.Add(this.numNamSX);
            this.gbTiepNhan.Controls.Add(this.txtHieuXe);
            this.gbTiepNhan.Controls.Add(this.txtDiaChi);
            this.gbTiepNhan.Controls.Add(this.txtDienThoai);
            this.gbTiepNhan.Controls.Add(this.txtTenKH);
            this.gbTiepNhan.Controls.Add(this.txtBienSo);
            this.gbTiepNhan.Controls.Add(this.lblNamSX);
            this.gbTiepNhan.Controls.Add(this.lblHieuXe);
            this.gbTiepNhan.Controls.Add(this.lblDiaChi);
            this.gbTiepNhan.Controls.Add(this.lblDienThoai);
            this.gbTiepNhan.Controls.Add(this.lblTenKH);
            this.gbTiepNhan.Controls.Add(this.lblBienSo);
            this.gbTiepNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTiepNhan.Location = new System.Drawing.Point(12, 12);
            this.gbTiepNhan.Name = "gbTiepNhan";
            this.gbTiepNhan.Size = new System.Drawing.Size(370, 275);
            this.gbTiepNhan.TabIndex = 0;
            this.gbTiepNhan.TabStop = false;
            this.gbTiepNhan.Text = "1. Tiếp Nhận Xe && Chủ Xe";
            // 
            // btnLuuXe
            // 
            this.btnLuuXe.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLuuXe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuXe.Location = new System.Drawing.Point(100, 230);
            this.btnLuuXe.Name = "btnLuuXe";
            this.btnLuuXe.Size = new System.Drawing.Size(250, 30);
            this.btnLuuXe.TabIndex = 13;
            this.btnLuuXe.Text = "Tiếp Nhận / Lưu Thông Tin Xe";
            this.btnLuuXe.UseVisualStyleBackColor = false;
            this.btnLuuXe.Click += new System.EventHandler(this.btnLuuXe_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(265, 23);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(85, 25);
            this.btnTraCuu.TabIndex = 12;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // numNamSX
            // 
            this.numNamSX.Location = new System.Drawing.Point(100, 196);
            this.numNamSX.Maximum = new decimal(new int[] { 2035, 0, 0, 0 });
            this.numNamSX.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            this.numNamSX.Name = "numNamSX";
            this.numNamSX.Size = new System.Drawing.Size(250, 23);
            this.numNamSX.TabIndex = 11;
            this.numNamSX.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Location = new System.Drawing.Point(100, 162);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.Size = new System.Drawing.Size(250, 23);
            this.txtHieuXe.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(100, 128);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 23);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(100, 93);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(250, 23);
            this.txtDienThoai.TabIndex = 8;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(100, 59);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(250, 23);
            this.txtTenKH.TabIndex = 7;
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(100, 25);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(155, 23);
            this.txtBienSo.TabIndex = 6;
            // 
            // lblNamSX
            // 
            this.lblNamSX.AutoSize = true;
            this.lblNamSX.Location = new System.Drawing.Point(15, 198);
            this.lblNamSX.Name = "lblNamSX";
            this.lblNamSX.Size = new System.Drawing.Size(53, 15);
            this.lblNamSX.TabIndex = 5;
            this.lblNamSX.Text = "Năm SX:";
            // 
            // lblHieuXe
            // 
            this.lblHieuXe.AutoSize = true;
            this.lblHieuXe.Location = new System.Drawing.Point(15, 165);
            this.lblHieuXe.Name = "lblHieuXe";
            this.lblHieuXe.Size = new System.Drawing.Size(50, 15);
            this.lblHieuXe.TabIndex = 4;
            this.lblHieuXe.Text = "Hiệu xe:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(15, 131);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(46, 15);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(15, 96);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(64, 15);
            this.lblDienThoai.TabIndex = 2;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(15, 62);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(49, 15);
            this.lblTenKH.TabIndex = 1;
            this.lblTenKH.Text = "Tên chủ:";
            // 
            // lblBienSo
            // 
            this.lblBienSo.AutoSize = true;
            this.lblBienSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienSo.Location = new System.Drawing.Point(15, 28);
            this.lblBienSo.Name = "lblBienSo";
            this.lblBienSo.Size = new System.Drawing.Size(51, 15);
            this.lblBienSo.TabIndex = 0;
            this.lblBienSo.Text = "Biển số:";
            // 
            // gbDichVu
            // 
            this.gbDichVu.Controls.Add(this.dgvChiTiet);
            this.gbDichVu.Controls.Add(this.btnThemChiTiet);
            this.gbDichVu.Controls.Add(this.txtTienCong);
            this.gbDichVu.Controls.Add(this.lblTienCong);
            this.gbDichVu.Controls.Add(this.numSoLuong);
            this.gbDichVu.Controls.Add(this.lblSoLuong);
            this.gbDichVu.Controls.Add(this.cboPhuTung);
            this.gbDichVu.Controls.Add(this.lblPhuTung);
            this.gbDichVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDichVu.Location = new System.Drawing.Point(395, 12);
            this.gbDichVu.Name = "gbDichVu";
            this.gbDichVu.Size = new System.Drawing.Size(577, 335);
            this.gbDichVu.TabIndex = 1;
            this.gbDichVu.TabStop = false;
            this.gbDichVu.Text = "2. Chọn Phụ Tùng Thay Thế && Tiền Công";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(16, 96);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(546, 225);
            this.dgvChiTiet.TabIndex = 7;
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThemChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiTiet.Location = new System.Drawing.Point(400, 56);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(162, 28);
            this.btnThemChiTiet.TabIndex = 6;
            this.btnThemChiTiet.Text = "+ Thêm Vào Danh Sách";
            this.btnThemChiTiet.UseVisualStyleBackColor = false;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // txtTienCong
            // 
            this.txtTienCong.Location = new System.Drawing.Point(265, 59);
            this.txtTienCong.Name = "txtTienCong";
            this.txtTienCong.Size = new System.Drawing.Size(115, 23);
            this.txtTienCong.TabIndex = 5;
            this.txtTienCong.Text = "0";
            // 
            // lblTienCong
            // 
            this.lblTienCong.AutoSize = true;
            this.lblTienCong.Location = new System.Drawing.Point(198, 62);
            this.lblTienCong.Name = "lblTienCong";
            this.lblTienCong.Size = new System.Drawing.Size(63, 15);
            this.lblTienCong.TabIndex = 4;
            this.lblTienCong.Text = "Tiền công:";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(82, 59);
            this.numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(89, 23);
            this.numSoLuong.TabIndex = 3;
            this.numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(15, 62);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(57, 15);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // cboPhuTung
            // 
            this.cboPhuTung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuTung.FormattingEnabled = true;
            this.cboPhuTung.Location = new System.Drawing.Point(82, 24);
            this.cboPhuTung.Name = "cboPhuTung";
            this.cboPhuTung.Size = new System.Drawing.Size(480, 23);
            this.cboPhuTung.TabIndex = 1;
            // 
            // lblPhuTung
            // 
            this.lblPhuTung.AutoSize = true;
            this.lblPhuTung.Location = new System.Drawing.Point(15, 27);
            this.lblPhuTung.Name = "lblPhuTung";
            this.lblPhuTung.Size = new System.Drawing.Size(59, 15);
            this.lblPhuTung.TabIndex = 0;
            this.lblPhuTung.Text = "Phụ tùng:";
            // 
            // gbPhieuSuaChua
            // 
            this.gbPhieuSuaChua.Controls.Add(this.btnThanhToan);
            this.gbPhieuSuaChua.Controls.Add(this.txtMaPhieuThanhToan);
            this.gbPhieuSuaChua.Controls.Add(this.lblMaPhieuTT);
            this.gbPhieuSuaChua.Controls.Add(this.btnLuuPhieu);
            this.gbPhieuSuaChua.Controls.Add(this.lblTongTien);
            this.gbPhieuSuaChua.Controls.Add(this.lblTextTongTien);
            this.gbPhieuSuaChua.Controls.Add(this.txtNoiDungSua);
            this.gbPhieuSuaChua.Controls.Add(this.lblNoiDung);
            this.gbPhieuSuaChua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPhieuSuaChua.Location = new System.Drawing.Point(12, 353);
            this.gbPhieuSuaChua.Name = "gbPhieuSuaChua";
            this.gbPhieuSuaChua.Size = new System.Drawing.Size(960, 160);
            this.gbPhieuSuaChua.TabIndex = 2;
            this.gbPhieuSuaChua.TabStop = false;
            this.gbPhieuSuaChua.Text = "3. Lập Phiếu Sửa Chữa (SqlTransaction) && Thanh Toán";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.PaleGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(685, 95);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(260, 45);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh Toán && Xuất Hóa Đơn";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtMaPhieuThanhToan
            // 
            this.txtMaPhieuThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuThanhToan.Location = new System.Drawing.Point(825, 45);
            this.txtMaPhieuThanhToan.Name = "txtMaPhieuThanhToan";
            this.txtMaPhieuThanhToan.Size = new System.Drawing.Size(120, 25);
            this.txtMaPhieuThanhToan.TabIndex = 6;
            // 
            // lblMaPhieuTT
            // 
            this.lblMaPhieuTT.AutoSize = true;
            this.lblMaPhieuTT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuTT.Location = new System.Drawing.Point(685, 49);
            this.lblMaPhieuTT.Name = "lblMaPhieuTT";
            this.lblMaPhieuTT.Size = new System.Drawing.Size(129, 15);
            this.lblMaPhieuTT.TabIndex = 5;
            this.lblMaPhieuTT.Text = "Mã Phiếu Thanh Toán:";
            // 
            // btnLuuPhieu
            // 
            this.btnLuuPhieu.BackColor = System.Drawing.Color.SandyBrown;
            this.btnLuuPhieu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieu.Location = new System.Drawing.Point(415, 95);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(240, 45);
            this.btnLuuPhieu.TabIndex = 4;
            this.btnLuuPhieu.Text = "LẬP PHIẾU (SqlTransaction)";
            this.btnLuuPhieu.UseVisualStyleBackColor = false;
            this.btnLuuPhieu.Click += new System.EventHandler(this.btnLuuPhieu_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Crimson;
            this.lblTongTien.Location = new System.Drawing.Point(495, 45);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(59, 21);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // lblTextTongTien
            // 
            this.lblTextTongTien.AutoSize = true;
            this.lblTextTongTien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextTongTien.Location = new System.Drawing.Point(415, 46);
            this.lblTextTongTien.Name = "lblTextTongTien";
            this.lblTextTongTien.Size = new System.Drawing.Size(75, 20);
            this.lblTextTongTien.TabIndex = 2;
            this.lblTextTongTien.Text = "Tổng tiền:";
            // 
            // txtNoiDungSua
            // 
            this.txtNoiDungSua.Location = new System.Drawing.Point(100, 30);
            this.txtNoiDungSua.Multiline = true;
            this.txtNoiDungSua.Name = "txtNoiDungSua";
            this.txtNoiDungSua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDungSua.Size = new System.Drawing.Size(280, 110);
            this.txtNoiDungSua.TabIndex = 1;
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(15, 33);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(81, 15);
            this.lblNoiDung.TabIndex = 0;
            this.lblNoiDung.Text = "Nội dung sửa:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 526);
            this.Controls.Add(this.gbPhieuSuaChua);
            this.Controls.Add(this.gbDichVu);
            this.Controls.Add(this.gbTiepNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Garage & Bảo Dưỡng Ô Tô";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTiepNhan.ResumeLayout(false);
            this.gbTiepNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNamSX)).EndInit();
            this.gbDichVu.ResumeLayout(false);
            this.gbDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.gbPhieuSuaChua.ResumeLayout(false);
            this.gbPhieuSuaChua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTiepNhan;
        private System.Windows.Forms.Label lblBienSo;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblHieuXe;
        private System.Windows.Forms.Label lblNamSX;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHieuXe;
        private System.Windows.Forms.NumericUpDown numNamSX;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnLuuXe;

        private System.Windows.Forms.GroupBox gbDichVu;
        private System.Windows.Forms.Label lblPhuTung;
        private System.Windows.Forms.ComboBox cboPhuTung;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblTienCong;
        private System.Windows.Forms.TextBox txtTienCong;
        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;

        private System.Windows.Forms.GroupBox gbPhieuSuaChua;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDungSua;
        private System.Windows.Forms.Label lblTextTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.Label lblMaPhieuTT;
        private System.Windows.Forms.TextBox txtMaPhieuThanhToan;
        private System.Windows.Forms.Button btnThanhToan;
    }
}