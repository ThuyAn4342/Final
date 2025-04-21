use FlightManagement
go 
--/*-----------QUY ĐỊNH-----------*/
--Cập nhật quy định
CREATE PROCEDURE sp_CapNhatQuyDinh
    @maQD INT,
    @tenQD NVARCHAR(255),
    @noiDungQD NVARCHAR(MAX),
    @ngayCapNhat DATE
AS
BEGIN
    UPDATE QUYDINH
    SET tenQD = @tenQD,
        noidungQD = @noiDungQD,
        ngayCapNhat = @ngayCapNhat
    WHERE maQD = @maQD;
END
GO

/*--------SÂN BAY-------*/
--Thêm sân bay
CREATE PROC sp_ThemSanBay
	@TenSanBay NVARCHAR(255),
	@TinhThanh NVARCHAR(255),
	@QuocGia NVARCHAR(255)
AS
BEGIN
	INSERT INTO SanBay(tenSB, tinhThanh, quocGia) Values (@TenSanBay, @TinhThanh, @QuocGia)
END
GO
--Cập nhật sân bay
CREATE PROCEDURE sp_CapNhatSanBay
    @maSB INT,
    @tenSB NVARCHAR(255),
    @tinhThanh NVARCHAR(255),
    @quocGia NVARCHAR(255)
AS
BEGIN
    UPDATE SanBay
    SET tenSB = @tenSB,
        tinhThanh = @tinhThanh,
        quocGia = @quocGia
    WHERE maSB = @maSB;
END
GO
--Kiểm tra khóa ngoại sân bay 
CREATE PROCEDURE sp_KiemTraKhoaNgoaiSanBay
    @maSB INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        (SELECT COUNT(*) FROM TuyenBay WHERE sanBayDi = @maSB OR sanBayDen = @maSB) +
        (SELECT COUNT(*) FROM SanBayTrungGian WHERE maSB = @maSB) AS TongLienKet;
END
GO
--Xóa sân bay
CREATE PROCEDURE sp_XoaSanBay
    @ID INT
AS
BEGIN
    DELETE FROM SanBay WHERE maSB = @ID;
END
GO

/*-------MÁY BAY-------*/
--Thêm máy bay
CREATE PROCEDURE sp_ThemMayBay
    @TenMB NVARCHAR(255),
    @slGheH1 INT,
    @slGhePT INT,
    @maLoaiMB INT
AS
BEGIN

    INSERT INTO MayBay (tenMB, slGheH1, slGhePT, maLoaiMB)
    VALUES (@TenMB, @slGheH1, @slGhePT, @maLoaiMB);
END
GO
--Cập nhật máy bay
CREATE PROCEDURE sp_CapNhatMayBay
    @maMB INT,
    @tenMB NVARCHAR(255),
    @slGheH1 INT,
    @slGhePT INT,
    @maLoaiMB INT
AS
BEGIN
    UPDATE MayBay 
    SET 
        tenMB = @tenMB,
        slGheH1 = @slGheH1,
        slGhePT = @slGhePT,
        maLoaiMB = @maLoaiMB
    WHERE maMB = @maMB;
END
GO
--Kiểm tra khóa ngoại ở Ghế khi xóa máy bay
ALTER PROCEDURE sp_CheckForeignKey_MayBay
    @maMB INT
AS
BEGIN
    -- Kiểm tra xem có ghế nào liên kết với máy bay này không
    SELECT COUNT(*) FROM Ghe WHERE maMB = @maMB
END
GO
--Xóa máy bay
CREATE PROCEDURE sp_XoaMayBay
    @ID INT
AS
BEGIN
    DELETE FROM MayBay WHERE maMB = @ID;
END

/*--------TÀI KHOẢN NGƯỜI DÙNG-------*/
--Login
CREATE PROC sp_Login @tenDangNhap varchar(255),
                     @matKhau varchar(255)
AS
BEGIN
    SELECT * FROM NguoiDung WHERE tenDangNhap = @tenDangNhap AND matKhau = @matKhau;
END
GO

--Lấy mail bằng tên đăng nhập
CREATE PROC sp_GetEmailByUsername @tenDangNhap varchar(255)                  
AS
BEGIN
    SELECT mail FROM NguoiDung WHERE tenDangNhap = @tenDangNhap
END
GO

--Lấy danh sách người dùng
CREATE PROC sp_LayDSNguoiDungTheoChucNang @ChucNangId INT
AS
BEGIN
	IF @ChucNangId = 0
	BEGIN
		SELECT* FROM NguoiDung 
	END
	ELSE
	BEGIN
		SELECT * FROM NguoiDung WHERE ChucNangId = @ChucNangId
	END
END
GO

--Lấy người dùng qua id
CREATE PROC sp_LayNguoiDungQuaId @id INT
AS
BEGIN
    SELECT * FROM NguoiDung WHERE maND = @id;
END
GO

--Kiểm tra tên đăng nhập đã tồn tại hay chưa
CREATE PROC sp_KiemTraTenDNTonTai @tenDangNhap varchar(255)
AS
BEGIN
    SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @TenDangNhap
END
GO

--Thêm người dùng mới
CREATE PROC sp_AddNguoiDung @hoTenND nvarchar(255),
							@tenDangNhap varchar(255),
							@ChucNangId int, 
							@soDT varchar(20), 
							@matKhau varchar(255), 
							@linkAnh varchar(255),
							@mail varchar(100)
AS
BEGIN
    INSERT INTO NguoiDung (hoTenND, tenDangNhap, ChucNangId, soDT, matKhau, linkAnh, mail) 
    VALUES(@hoTenND, @tenDangNhap, @ChucNangId, @soDT, @matKhau, @linkAnh, @mail)
END
GO

--Xóa người dùng
CREATE PROC sp_XoaNguoiDung @maND int
AS
BEGIN
    DELETE FROM NguoiDung WHERE maND = @maND
END
GO

--Cập nhật thông tin
CREATE PROC sp_CapNhatNguoiDung @maND int,
								@hoTenND nvarchar(255),
								@tenDangNhap varchar(255),
								@ChucNangId int, 
								@soDT varchar(20), 
								@matKhau varchar(255), 
								@linkAnh varchar(255),
								@mail varchar(100)
AS
BEGIN
    UPDATE NguoiDung SET hoTenND =@hoTenND, tenDangNhap=@tenDangNhap, ChucNangId=@ChucNangId,
	soDT = @soDT, matKhau=@matKhau, linkAnh=@linkAnh, mail=@mail WHERE maND =@maND
END
GO

--Lấy user qua tên đăng nhập
CREATE PROC sp_LayNDQuaTenDN @tenDangNhap varchar(255)								
AS
BEGIN
    SELECT * FROM NguoiDung WHERE tenDangNhap = @tenDangNhap
END
GO

--Đổi mật khẩu
CREATE PROC sp_DoiMatKhau @matKhau varchar(255),
						  @tenDangNhap varchar(255)
AS
BEGIN
    UPDATE NguoiDung SET  matKhau=@matKhau WHERE tenDangNhap=@tenDangNhap
END
GO

/*--------THỐNG KÊ-------*/
--Thống kê theo tháng, năm
CREATE PROC sp_ThongKeTheoThangNam @thang INT, @nam INT
AS
BEGIN
	IF @thang IS NULL
	BEGIN
		SELECT tb.maTB, tb.tenTB, SUM(v.giaVe) AS doanhThu, COUNT(DISTINCT cb.maCB) AS soLuotBay
		FROM TuyenBay tb FULL JOIN ChuyenBay cb ON tb.maTB = cb.maTB
						 FULL JOIN Ghe_ChuyenBay gcb ON cb.maCB = gcb.maCB
						 FULL JOIN VeChuyenBay v ON gcb.maGhe = v.maGhe AND cb.maCB = v.maCB
						 FULL JOIN HoaDon hd ON v.maHD = hd.maHD   
		WHERE  cb.tienTrinhID <> 4 AND YEAR(cb.ngayGioDi) = @nam
		GROUP BY tb.maTB, tb.tenTB 
		ORDER BY doanhThu DESC

		RETURN
	END
	SELECT tb.maTB, tb.tenTB, SUM(v.giaVe) AS doanhThu, COUNT(DISTINCT cb.maCB) AS soLuotBay
	FROM TuyenBay tb FULL JOIN ChuyenBay cb ON tb.maTB = cb.maTB
					 FULL JOIN Ghe_ChuyenBay gcb ON cb.maCB = gcb.maCB
				     FULL JOIN VeChuyenBay v ON gcb.maGhe = v.maGhe AND cb.maCB = v.maCB
					 FULL JOIN HoaDon hd ON v.maHD = hd.maHD   
	WHERE cb.tienTrinhID <> 4 AND MONTH(cb.ngayGioDi) = @thang AND YEAR(cb.ngayGioDi) = @nam
	GROUP BY tb.maTB, tb.tenTB 
	ORDER BY doanhThu DESC
END
GO

/*--------VÉ CHUYẾN BAY-------*/
--Lấy danh sách vé
CREATE PROC sp_LayDSVeChuyenBay
AS
BEGIN
    SELECT * FROM VeChuyenBay
END
GO

--Lấy sân bay đi của vé
CREATE PROC sp_LaySanBayDi @maCB int
AS
BEGIN
    SELECT sb.tenSB AS sanBayDi  
	FROM ChuyenBay cb, TuyenBay tb, SanBay sb  
	WHERE cb.maTB=tb.maTB AND tb.sanBayDi =sb.maSB AND cb.maCB = @maCB
END
GO

--Lấy sân bay đến của vé
CREATE PROC sp_LaySanBayDen @maCB int
AS
BEGIN
    SELECT sb.tenSB AS sanBayDi  
	FROM ChuyenBay cb, TuyenBay tb, SanBay sb  
	WHERE cb.maTB=tb.maTB AND tb.sanBayDen =sb.maSB AND cb.maCB = @maCB
END
GO

--Lấy thông tin vé 
CREATE PROCEDURE sp_TraCuuThongTinVe
    @maVe INT
AS
BEGIN
    SELECT 
        ve.maVe,
        ve.tenHK,
        hd.maHD,
        hd.ngayLapHD,
        cb.maCB,
        cb.ngayGioDi,
        tb.tenTB,
        sbDi.tinhThanh + ' - ' + sbDen.tinhThanh AS tuyenBay,
        g.tenGhe,
        g.hangGhe,
        ve.giaVe,
        CASE 
            WHEN gcb.trangThai = 0 THEN N'Chưa sử dụng' 
            ELSE N'Đã sử dụng' 
        END AS trangThai
    FROM VeChuyenBay ve
    JOIN HoaDon hd ON ve.maHD = hd.maHD
    JOIN Ghe_ChuyenBay gcb ON ve.maGhe = gcb.maGhe
    JOIN Ghe g ON gcb.maGhe = g.maGhe
    JOIN ChuyenBay cb ON cb.maCB = gcb.maCB
    JOIN TuyenBay tb ON cb.maTB = tb.maTB
    JOIN SanBay sbDi ON tb.sanBayDi = sbDi.maSB
    JOIN SanBay sbDen ON tb.sanBayDen = sbDen.maSB
    WHERE ve.maVe = @maVe
END
GO

--Lấy tổng số vé theo năm, tháng
CREATE PROC sp_LaySoLuongVeTheoNamThang @thang INT, @nam INT
AS
BEGIN
	IF @thang IS NULL
	BEGIN
		SELECT COUNT(v.maVe) AS soLuongVe
		FROM VeChuyenBay v JOIN ChuyenBay cb ON v.maCB = cb.maCB
						   JOIN Ghe g ON v.maGhe = g.maGhe
		WHERE YEAR(cb.ngayGioDi) = @nam
		RETURN
	END
	SELECT COUNT(v.maVe) AS soLuongVe
	FROM VeChuyenBay v JOIN ChuyenBay cb ON v.maCB = cb.maCB
					   JOIN Ghe g ON v.maGhe = g.maGhe
	WHERE MONTH(cb.ngayGioDi) = @thang AND YEAR(cb.ngayGioDi) = @nam
END
GO

--Xóa vé theo mã vé
CREATE PROC sp_XoaVeTheoMaVe @maVe int
AS
BEGIN
    DELETE FROM VeChuyenBay WHERE maVe = @maVe
END
GO

--Xóa vé của chuyến bay
CREATE PROC sp_XoaVeCuaChuyenBay @maCB int
AS
BEGIN
    DELETE FROM VeChuyenBay 
	WHERE maVe IN (SELECT v.maVe  
				   FROM VeChuyenBay v, Ghe_ChuyenBay gcb 
				   WHERE v.maGhe = gcb.maGhe AND v.maCB = gcb.maCB AND gcb.maCB =@maCB)
END
GO


/*--------HÓA ĐƠN-------*/
--Lấy danh sách các hóa đơn
CREATE PROC sp_LayDSHoaDon 
AS
BEGIN
   SELECT * FROM HoaDon
END
GO

--Lấy thông tin hóa đơn
CREATE PROC sp_LayThongTinHoaDon @maHD INT
AS
BEGIN
	SELECT maHD,ngayLapHD,soLuongVe,phuongThucTT, tongTien, hoTenND AS nguoiLapHD
	FROM HoaDon, NguoiDung 
	WHERE HoaDon.maND = NguoiDung.maND AND maHD = @maHD
END
GO

--Lấy danh sách vé của hóa đơn
CREATE PROC sp_LayDSVeCuaHD @maHD INT
AS
BEGIN
	SELECT v.maVe, v.tenHK,v.maCB, g.tenGhe, v.giaVe, hd.maHD,
			CASE 
				WHEN gcb.trangThai = 0 THEN N'Chưa sử dụng' 
				ELSE N'Đã sử dụng' 
			END AS trangThai
    FROM VeChuyenBay v,HoaDon hd , Ghe g, Ghe_ChuyenBay gcb
    WHERE hd.maHD = v.maHD 
		AND v.maGhe = g.maGhe 
		AND v.maCB =gcb.maCB AND v.maGhe = gcb.maGhe 
		AND hd.maHD = @maHD
	
END
GO

--Cập nhật thông tin hóa đơn
CREATE PROC sp_CapNhatHoaDon @maHD int,
							 @soLuongVe int,
							 @tongTien float
AS
BEGIN
   UPDATE HoaDon SET soLuongVe =@soLuongVe, tongTien=@tongTien WHERE maHD =@maHD
END
GO

--Xóa hóa đơn
CREATE PROC sp_XoaHoaDon @maHD int
AS
BEGIN
   DELETE FROM HoaDon WHERE maHD = @maHD
END
GO
