# BÁO CÁO BÀI TẬP / ĐỒ ÁN

## THÔNG TIN SINH VIÊN
- **Họ và tên:** Nguyễn Khánh Đức
- **Mã số sinh viên:** 24810320072
- **Lớp:** D19QTANM1
- **Tên môn học:** Lập trình C# / Windows Forms
- **Tên bài tập:** BÀI 6.4: HỆ THỐNG QUẢN LÝ GARAGE VÀ BẢO BƯỠNG XE Ô TÔ
(GARAGE MANAGEMENT SYSTEM)

---

## KẾT QUẢ THỰC HÀNH

- Giao diện chính
<img width="1445" height="797" alt="Screenshot 2026-11-10 190646" src="https://github.com/user-attachments/assets/c60837d2-8697-46bd-a93c-330729166ac3" />

- Xác nhận lưu thông tin khách hàng
<img width="1442" height="795" alt="Screenshot 2026-11-10 190711" src="https://github.com/user-attachments/assets/ab449899-e782-435a-935c-6056c3e1151b" />

- Lấy số phiếu
<img width="1436" height="802" alt="Screenshot 2026-11-10 190736" src="https://github.com/user-attachments/assets/0a6c87c6-2b1a-4e38-97a4-41c0f4f05780" />

- Xác nhận thanh toán số phiếu
<img width="1442" height="794" alt="Screenshot 2026-11-10 190742" src="https://github.com/user-attachments/assets/99ca2f43-937f-42c5-a53d-70bba5e60188" />

## HƯỚNG DẪN CÀI ĐẶT VÀ CHẠY DỰ ÁN:
1. **Khởi tạo CSDL**:
   - Mở file `Database.sql` có sẵn trong thư mục dự án bằng SQL Server Management Studio (SSMS) hoặc Visual Studio.
   - Chạy toàn bộ script (Execute) để tự động tạo CSDL `GarageDB` cùng các bảng và dữ liệu mẫu.

2. **Cấu hình chuỗi kết nối**:
   - Mở file `Dbhelper.cs`.
   - Kiểm tra và đổi lại `Data Source` cho khớp với tên SQL Server trên máy chấm (Mặc định đang để kết nối tới `(localdb)\MSSQLLocalDB`).

3. **Chạy chương trình**:
   - Nhấn **F5** (hoặc nút Start) trên Visual Studio để chạy hệ thống.
