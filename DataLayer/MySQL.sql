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




