USE master;
GO
CREATE DATABASE FlightManagement;
GO
USE FlightManagement;
GO

SET DATEFORMAT dmy;

-- Bảng Quy định
CREATE TABLE QuyDinh (
    maQD INT IDENTITY(1,1) PRIMARY KEY,
    tenQD NVARCHAR(255) UNIQUE,
    noidungQD NVARCHAR(MAX),
    ngayCapNhat DATE
);

-- Bảng Sân bay
CREATE TABLE SanBay (
    maSB INT IDENTITY(1,1) PRIMARY KEY,
    tenSB NVARCHAR(255) UNIQUE,
    tinhThanh NVARCHAR(255),
    quocGia NVARCHAR(255)
);

-- Bảng Tuyến bay
CREATE TABLE TuyenBay (
    maTB INT IDENTITY(1,1) PRIMARY KEY,
    tenTB NVARCHAR(255) UNIQUE,
    sanBayDi INT,
    sanBayDen INT,
    giaTB FLOAT,
    FOREIGN KEY (sanBayDi) REFERENCES SanBay(maSB),
    FOREIGN KEY (sanBayDen) REFERENCES SanBay(maSB)
);

-- Bảng Tiến trình chuyến bay (ENUM)
CREATE TABLE TienTrinh (
    id TINYINT PRIMARY KEY,
    ten NVARCHAR(50) NOT NULL UNIQUE,
    CONSTRAINT CK_TienTrinh_Enum CHECK (id IN (1, 2, 3))
);

-- Bảng Chuyến bay
CREATE TABLE ChuyenBay (
    maCB INT IDENTITY(1,1) PRIMARY KEY,
    ngayGioDi DATETIME,
    thoiGianBay INT,
    tienTrinhID TINYINT NOT NULL,
    maTB INT,
    FOREIGN KEY (maTB) REFERENCES TuyenBay(maTB),
    CONSTRAINT FK_TienTrinh FOREIGN KEY (tienTrinhID) REFERENCES TienTrinh(id)
);

-- Bảng Sân bay trung gian
CREATE TABLE SanBayTrungGian (
    maSB INT,
    maTB INT,
    thoiGianDung INT,
    PRIMARY KEY (maSB, maTB),
    FOREIGN KEY (maSB) REFERENCES SanBay(maSB),
    FOREIGN KEY (maTB) REFERENCES TuyenBay(maTB)
);

-- Bảng Loại máy bay
CREATE TABLE LoaiMayBay (
    maLoaiMB INT IDENTITY(1,1) PRIMARY KEY,
    tenLoaiMB NVARCHAR(255) UNIQUE
);

-- Bảng Máy bay
CREATE TABLE MayBay (
    maMB INT IDENTITY(1,1) PRIMARY KEY,
    tenMB VARCHAR(255) UNIQUE,
    slGheH1 INT,
    slGhePT INT,
    maLoaiMB INT,
    FOREIGN KEY (maLoaiMB) REFERENCES LoaiMayBay(maLoaiMB)
);

-- Bảng Ghế
CREATE TABLE Ghe (
    maGhe INT IDENTITY(1,1) PRIMARY KEY,
    tenGhe NVARCHAR(255) UNIQUE,
    hangGhe NVARCHAR(50),
    maMB INT,
    tileGia FLOAT,
    FOREIGN KEY (maMB) REFERENCES MayBay(maMB)
);

-- Bảng Ghế_ChuyếnBay
CREATE TABLE Ghe_ChuyenBay (
    maGhe INT,
    maCB INT,
    trangThai BIT,
    gia FLOAT,
    PRIMARY KEY (maGhe, maCB),
    FOREIGN KEY (maGhe) REFERENCES Ghe(maGhe),
    FOREIGN KEY (maCB) REFERENCES ChuyenBay(maCB)
);

-- Bảng Chức năng (ENUM)
CREATE TABLE ChucNang (
    id TINYINT PRIMARY KEY,
    ten NVARCHAR(50) NOT NULL UNIQUE,
    CONSTRAINT CK_ChucNang_Enum CHECK (id IN (1, 2, 3))
);

-- Bảng Người dùng
CREATE TABLE NguoiDung (
    maND INT IDENTITY(1,1) PRIMARY KEY,
    hoTenND NVARCHAR(255),
    tenDangNhap VARCHAR(255) NOT NULL UNIQUE,
    ChucNangId TINYINT NOT NULL,
    soDT VARCHAR(20),
    matKhau VARCHAR(255),
    linkAnh VARCHAR(255),
    CONSTRAINT FK_NguoiDung_ChucNang FOREIGN KEY (ChucNangId) REFERENCES ChucNang(Id)
);

-- Bảng Hóa đơn
CREATE TABLE HoaDon (
    maHD INT IDENTITY(1,1) PRIMARY KEY,
    ngayLapHD DATE,
    soLuongVe INT,
    tongTien FLOAT,
    phuongThucTT NVARCHAR(255),
    maND INT,
    FOREIGN KEY (maND) REFERENCES NguoiDung(maND)
);

-- Bảng Vé chuyến bay
CREATE TABLE VeChuyenBay (
    maVe INT IDENTITY(1,1) PRIMARY KEY,
    tenHK NVARCHAR(255) UNIQUE,
    maHD INT,
    maGhe INT,
    maCB INT,
    FOREIGN KEY (maHD) REFERENCES HoaDon(maHD),
    FOREIGN KEY (maGhe, maCB) REFERENCES Ghe_ChuyenBay(maGhe, maCB)
);



-----------------INSERT DỮ LIỆU------------------

-- Insert dữ liệu vào bảng QuyDinh
-- Insert dữ liệu vào bảng QuyDinh
INSERT INTO QuyDinh (tenQD, noidungQD, ngayCapNhat) 
VALUES (N'Số sân bay trung gian tối đa', N'Không quá 2 sân bay trung gian.', '2024-01-01');

-- Insert dữ liệu vào bảng SanBay
INSERT INTO SanBay (tenSB, tinhThanh, quocGia) 
VALUES (N'Tân Sơn Nhất', N'TP. HCM', N'Việt Nam'),
       (N'Nội Bài', N'Hà Nội', N'Việt Nam'),
       (N'Đà Nẵng', N'Đà Nẵng', N'Việt Nam');

-- Insert dữ liệu vào bảng TuyenBay
INSERT INTO TuyenBay (tenTB, sanBayDi, sanBayDen, giaTB) 
VALUES (N'HCM - Hà Nội', 1, 2, 2000000),
       (N'HCM - Đà Nẵng', 1, 3, 1500000);

-- Insert dữ liệu vào bảng TienTrinh
INSERT INTO TienTrinh (id, ten) 
VALUES (1, 'DangCho'),
       (2, 'DangBay'),
       (3, 'HoanThanh');

-- Insert dữ liệu vào bảng ChuyenBay
INSERT INTO ChuyenBay (ngayGioDi, thoiGianBay, tienTrinhID, maTB) 
VALUES ('15-03-2024 10:00:00', 120, 1, 1),
       ('16-02-2024 14:00:00', 90, 1, 2);

-- Insert dữ liệu vào bảng SanBayTrungGian
INSERT INTO SanBayTrungGian (maSB, maTB, thoiGianDung) 
VALUES (3, 1, 30); -- Đà Nẵng là sân bay trung gian cho tuyến HCM - Hà Nội

-- Insert dữ liệu vào bảng LoaiMayBay
INSERT INTO LoaiMayBay (tenLoaiMB) 
VALUES ('Boeing 777'),
       ('Airbus A320');

-- Insert dữ liệu vào bảng MayBay
INSERT INTO MayBay (tenMB, slGheH1, slGhePT, maLoaiMB) 
VALUES ('VN001', 20, 150, 1),
       ('VN002', 15, 135, 2);

-- Insert dữ liệu vào bảng Ghe
INSERT INTO Ghe (tenGhe, hangGhe, maMB, tileGia) 
VALUES ('A1', 'Hạng 1', 1, 1.5),
       ('A2', 'Hạng 1', 1, 1.5),
       ('B1', 'Hạng 2', 1, 1.0),
       ('B2', 'Hạng 2', 1, 1.0);

-- Insert dữ liệu vào bảng Ghe_ChuyenBay
INSERT INTO Ghe_ChuyenBay (maGhe, maCB, trangThai, gia) 
VALUES (1, 1, 0, 3000000),
       (2, 1, 1, 3000000),
       (3, 1, 0, 2000000),
       (4, 1, 1, 2000000);

-- Insert dữ liệu vào bảng ChucNang
INSERT INTO ChucNang (id, ten) 
VALUES (1, 'Admin'),
       (2, 'EMPL'),
       (3, 'USER');

-- Insert dữ liệu vào bảng NguoiDung
INSERT INTO NguoiDung (hoTenND, tenDangNhap, ChucNangId, soDT, matKhau, linkAnh) 
VALUES (N'Nguyễn Văn A', 'admin', 1, '0909123456', 'password123', 'linkAnh1'),
       (N'Trần Thị B', 'user1', 2, '0912123456', 'password123', 'linkAnh2');

-- Insert dữ liệu vào bảng HoaDon
INSERT INTO HoaDon (ngayLapHD, soLuongVe, tongTien, phuongThucTT, maND) 
VALUES ('03-12-2025', 2, 6000000, N'Thẻ tín dụng', 2),
       ('03-12-2024', 1, 2000000, N'Tiền mặt', 2);

-- Insert dữ liệu vào bảng VeChuyenBay
INSERT INTO VeChuyenBay (tenHK, maHD, maGhe, maCB) 
VALUES (N'Lê Văn C', 1, 1, 1),
       (N'Phạm Thị D', 1, 2, 1),
       (N'Ngô Văn E', 2, 3, 1);

select * From QuyDinh
--select * From SanBay
--select * From TuyenBay
--select * From TienTrinh
--select * From TuyenBay
--select * from SanBayTrungGian
--select * from LoaiMayBay
--select * From MayBay
--select * From Ghe
--select * From Ghe_ChuyenBay
--select * From ChucNang
--select * From NguoiDung
--select * From HoaDon
--select * From VeChuyenBay

--select n.*, c.ten as N'Chức vụ'
--from NguoiDung n, ChucNang c
--where n.ChucNangId = c.id

--select c.*, t.ten as N'Tiến trình'
--from TienTrinh t, ChuyenBay c
--where t.id = c.tienTrinhID


