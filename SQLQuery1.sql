CREATE DATABASE GarageDB;
GO
USE GarageDB;
GO

-- 1. Bảng KhachHang
CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY IDENTITY(1,1),
    TenKH NVARCHAR(100) NOT NULL,
    DienThoai VARCHAR(15) UNIQUE,
    DiaChi NVARCHAR(200)
);

-- 2. Bảng Xe
CREATE TABLE Xe (
    BienSo VARCHAR(20) PRIMARY KEY,
    MaKH INT FOREIGN KEY REFERENCES KhachHang(MaKH),
    HieuXe NVARCHAR(50),
    NamSanXuat INT
);

-- 3. Bảng PhuTung
CREATE TABLE PhuTung (
    MaPhuTung INT PRIMARY KEY IDENTITY(1,1),
    TenPhuTung NVARCHAR(150) NOT NULL,
    DonGia DECIMAL(18,2),
    SoLuongTon INT CHECK (SoLuongTon >= 0)
);

-- 4. Bảng PhieuSuaChua
CREATE TABLE PhieuSuaChua (
    MaPhieu INT PRIMARY KEY IDENTITY(1,1),
    BienSo VARCHAR(20) FOREIGN KEY REFERENCES Xe(BienSo),
    NgayNhan DATETIME DEFAULT GETDATE(),
    NoiDungSua NVARCHAR(MAX),
    TongTien DECIMAL(18,2) DEFAULT 0,
    TrangThai NVARCHAR(30) -- "Đang sửa", "Đã hoàn thành", "Đã thanh toán"
);

-- 5. Bảng ChiTietSuaChua
CREATE TABLE ChiTietSuaChua (
    MaPhieu INT FOREIGN KEY REFERENCES PhieuSuaChua(MaPhieu),
    MaPhuTung INT FOREIGN KEY REFERENCES PhuTung(MaPhuTung),
    SoLuong INT CHECK (SoLuong > 0),
    TienCong DECIMAL(18,2) DEFAULT 0,
    PRIMARY KEY (MaPhieu, MaPhuTung)
);

-- Thêm một số phụ tùng mẫu để test
INSERT INTO PhuTung (TenPhuTung, DonGia, SoLuongTon) VALUES 
(N'Lọc nhớt Toyota', 150000, 10),
(N'Bugi NGK Iridium', 120000, 20),
(N'Dầu động cơ Castrol 4L', 450000, 5),
(N'Má phanh trước Honda', 650000, 2);