use master
go
create database	QLNS
go

use QLNS
go

create table NhanVien
(
	MaNV int IDENTITY(1,1),
	TenNV nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(5),
	Phong int,
	NQL int,
	Luong float,
	Primary Key (MaNV)
)

create table PhongBan
(
	MaPB int IDENTITY(1,1),
	TenPB nvarchar(100),
	TruongPB int,
	ViTri nvarchar(100),

	Primary Key (MaPB)
	
)
create table DeAn
(
	MaDA int IDENTITY(1,1),
	TenDA nvarchar(50),
	Phong int,
	ChiPhi float,	
	Primary Key(MaDA)
)

create table PhanCong
(
	MaDA int,
	MaNV int,
	SoGio float,
	
	Primary Key(MaDA, MaNV)
)

--Khoá Ngo?i

-- NhanVien
ALter table NhanVien add constraint FK_NhanVien_NhanVien  FOREIGN KEY (NQL) references NhanVien(MaNV)
ALter table NhanVien add constraint FK_NhanVien_PhongBan  FOREIGN KEY (Phong) references PhongBan(MaPB)

--PhongBan
ALter table PhongBan add constraint FK_PhongBan_NhanVien FOREIGN KEY (TruongPB) references NhanVien(MaNV)
--DeAn
ALter table DeAn add constraint FK_DeAn_PhongBan FOREIGN KEY (Phong) references PhongBan(MaPB)
--PhanCong
ALter table PhanCong add constraint FK_PhanCong_NhanVien FOREIGN KEY (MaNV) references NhanVien(MaNV)
ALter table PhanCong add constraint FK_PhanCong_DeAn FOREIGN KEY (MaDA) references DeAn(MaDA)

--insert


--NhanVien
Insert into NhanVien (TenNV, NgaySinh, GioiTinh, Luong)
Values (N'T? T?n Phúc', '1985-6-29', N'Nam', 2400) --1(3)
Insert into NhanVien (TenNV, NgaySinh, GioiTinh, Luong)
Values (N'Nguy?n Ðình Hà', '1990-3-30', N'N?', 1000) --2 (1)
Insert into NhanVien (TenNV, NgaySinh, GioiTinh, Luong)
Values (N'Nguy?n Ng?c Minh', '1991-9-1', N'Nam', 3000) --3(3)
Insert into NhanVien (TenNV, NgaySinh, GioiTinh, Luong)
Values (N'Ðào Van Danh', '1992-12-22', N'Nam', 4000) --4(3)
Insert into NhanVien (TenNV, NgaySinh, GioiTinh, Luong)
Values (N'Tr?n Th? Ng?c', '1996-1-20', N'N?', 6100) --5 (1)
Insert into NhanVien (TenNV, NgaySinh, GioiTinh, Luong)
Values (N'Ðào Th? Hòa', '1988-10-26', N'N?', 3500) --6(1)
Insert into NhanVien (TenNV, NgaySinh, GioiTinh, Luong)
Values (N'Nguy?n Thành Ð?t', '1988-9-24', N'Nam', 4500) --7(2)
Insert into NhanVien (TenNV, NgaySinh, GioiTinh, Luong)
Values (N'Ðinh Duy Phuong', '1983-7-4', N'Nam', 3000) --8(2)
Insert into NhanVien (TenNV, NgaySinh, GioiTinh, Luong)
Values (N'Ph?m Van V?n', '1984-6-22', N'Nam', 5000) --9(3)
Insert into NhanVien (TenNV, NgaySinh, GioiTinh, Luong)
Values (N'Ð? Thanh H?i', '1988-3-15', N'N?', 4500) --10(1)
Insert into NhanVien (TenNV, NgaySinh, GioiTinh, Luong)
Values (N'Nguy?n Ð?c H?ng', '1985-5-13', N'N?', 4000) --11(2)
--PhongBan
Insert into PhongBan(TenPB, TruongPB, ViTri)
Values (N'Phòng Tài Chính', 5, N'Phòng 302 T?ng 3 Toà S1') -- 1
Insert into PhongBan(TenPB, TruongPB, ViTri)
Values (N'Phòng K? Ho?ch', 8, N'Phòng 405 T?ng 4 Toà S1') -- 2
Insert into PhongBan(TenPB, TruongPB, ViTri)
Values (N'Phòng Ki Thu?t', 3, N'Phòng 101 T?ng 1 Toà S1') -- 3

-- Update NhanVien
Update NhanVien set Phong = 1 where MaNV = 5 or MaNV = 2 or MaNV = 6 or MaNV = 10
Update NhanVien set Phong = 2 where MaNV = 8 or MaNV = 11 or MaNV = 7
Update NhanVien set Phong = 3 where MaNV = 1 or MaNV = 3 or MaNV = 4 or MaNV = 9
 
 Update NhanVien set NQL = 5 where MaNV = 2 or MaNV = 6 or MaNV = 10
 Update NhanVien set NQL = 8 where MaNV = 11 or MaNV = 7
 Update NhanVien set NQL = 3 where MaNV = 1 or MaNV = 4 or MaNV = 9

--Bang DeAn
Insert into DeAn (TenDA, Phong, ChiPhi)
values (N'T? Ch?c S? Ki?n', 2, 10000) -- 1 (2)
Insert into DeAn (TenDA, Phong, ChiPhi)
values (N'Kê Khai Doanh Thu Tháng 3', 1, 3000) -- 2 (1)
Insert into DeAn (TenDA, Phong, ChiPhi)
values (N'L?p Ð?t Server', 3, 400000) -- 3 (3)
Insert into DeAn (TenDA, Phong, ChiPhi)
values (N'Gi?i Ngân', 2, 1000) -- 4(2)
Insert into DeAn (TenDA, Phong, ChiPhi)
values (N'L?p Ð?t Camera', 3, 50000) -- 5(3)
-- PhanCong
Insert into PhanCong(MaDA, MaNV, SoGio)
values (1, 8, 40)
Insert into PhanCong(MaDA, MaNV, SoGio)
values (1, 11, 28)
Insert into PhanCong(MaDA, MaNV, SoGio)
values (1, 7, 30)
Insert into PhanCong(MaDA, MaNV, SoGio)
values (2, 5, 5)
Insert into PhanCong(MaDA, MaNV, SoGio)
values (2, 6, 23)
Insert into PhanCong(MaDA, MaNV, SoGio)
values (3, 1, 58)
Insert into PhanCong(MaDA, MaNV, SoGio)
values (3, 4, 60)
Insert into PhanCong(MaDA, MaNV, SoGio)
values (3, 9, 50)
Insert into PhanCong(MaDA, MaNV, SoGio)
values (4, 11, 43)
Insert into PhanCong(MaDA, MaNV, SoGio)
values (4, 7, 42)
Insert into PhanCong(MaDA, MaNV, SoGio)
values (5, 4, 57)
Insert into PhanCong(MaDA, MaNV, SoGio)
values (5, 3, 68)
Insert into PhanCong(MaDA, MaNV, SoGio)
values (5, 9, 46)



go
create proc themnv (@tennv nvarchar(50), @ngaysinh date, @gioitinh nvarchar(5), @phong int, @nql int, @luong float)
as
begin
	if(@phong = 0 and @nql = 0)
	begin
		insert into NhanVien(TenNV, NgaySinh, GioiTinh, Phong, NQL, Luong)
		values (@tennv, @ngaysinh, @gioitinh, null, null, @luong)
	end
	if(@phong != 0 and @nql = 0)
	begin
		insert into NhanVien(TenNV, NgaySinh, GioiTinh, Phong, NQL, Luong)
		values (@tennv, @ngaysinh, @gioitinh, @phong, null, @luong)
	end
	if(@phong = 0 and @nql != 0)
	begin
		insert into NhanVien(TenNV, NgaySinh, GioiTinh, Phong, NQL, Luong)
		values (@tennv, @ngaysinh, @gioitinh, null, @nql, @luong)
	end
	if(@phong != 0 and @nql != 0)
	begin
		insert into NhanVien(TenNV, NgaySinh, GioiTinh, Phong, NQL, Luong)
		values (@tennv, @ngaysinh, @gioitinh, @phong, @nql, @luong)
	end
end

go
create proc xoanv(@ma int)
as
begin
	if(@ma not in (select MaNV from NhanVien)) return
	if(@ma in (select TruongPB from PhongBan))
	begin
		update PhongBan
		set TruongPB = null
		where TruongPB = @ma
	end
	
	if(@ma in (select MaNV from PhanCong))
	begin
		delete PhanCong
		where MaNV = @ma
	end
	
	delete NhanVien
	where MaNV = @ma
end

go
create proc suanv(@ma int, @tennv nvarchar(50), @ngaysinh date, @gioitinh nvarchar(5), @phong int, @nql int, @luong float)
as
begin
	if (@ma not in  (select MaNV from NhanVien)) return

	if(len(@tennv) > 0)
	begin
		UPDATE NhanVien
		SET TenNV = @tennv
		WHERE MaNV = @ma
	end
	if((YEAR(@ngaysinh) - 1900) > 0)
	begin
		UPDATE NhanVien
		SET NgaySinh = @ngaysinh
		WHERE MaNV = @ma
	end

	if(len(@gioitinh) > 0)
	begin
		UPDATE NhanVien
		SET GioiTinh = @gioitinh
		WHERE MaNV = @ma
	end
	if(@luong > 0)
	begin
		UPDATE NhanVien
		SET Luong = @luong
		WHERE MaNV = @ma
	end
	if(@phong = 0)
	begin 
		update NhanVien
		set Phong = null
		where MaNV = @ma
	end
	else
	begin
		update NhanVien
		set Phong = @phong
		where MaNV = @ma
	end
	if(@nql = 0)
	begin 
		update NhanVien
		set NQL = null
		where MaNV = @ma
	end
	else 
	begin 
		update NhanVien
		set NQL = @nql
		where MaNV = @ma
	end
end


go
create proc thempb (@ten nvarchar(100), @truong int, @vitri nvarchar(100))
as
begin
	if(@truong = 0)
	begin 
		insert into PhongBan (TenPB, TruongPB, ViTri)
		values (@ten, null, @vitri)
		return
	end
	if(@truong not in (select MaNV from NhanVien)) return
	insert into PhongBan (TenPB, TruongPB, ViTri)
	values (@ten, @truong, @vitri)
end

go

create proc xoapb (@ma int)
as
begin
	if(@ma not in (select MaPB from PhongBan)) return

	if(@ma in (select Phong from NhanVien))
	begin
		update NhanVien
		set Phong = null
		where Phong = @ma
	end
	delete PhongBan where MaPB = @ma
end
go

create proc suapb (@ma int, @ten nvarchar(100), @truong int, @vitri nvarchar(100))
as 
begin
	if(@ma not in (select MaPB from PhongBan)) return
	if(LEN(@ten) > 0)
	begin
		update PhongBan
		set TenPB = @ten
		where MaPB = @ma
	end
	if(LEN(@vitri) > 0)
	begin
		update PhongBan
		set ViTri = @vitri
		where MaPB = @ma
	end
	if(@truong = 0)
	begin
		update PhongBan 
		set TruongPB = null
		where MaPB = @ma
	end
	if(@truong not in (select MaNV from NhanVien)) return
	if(@truong != 0)
	begin
		update PhongBan 
		set TruongPB = @truong
		where MaPB = @ma
	end
end

go
create proc themda (@ten nvarchar(50), @phong int, @chiphi float)
as
begin
	if(@phong = 0)
	begin 
		insert into DeAn (TenDA, Phong, ChiPhi)
		values (@ten, null, @chiphi)
		return
	end
	if(@phong not in (select MaPB from PhongBan)) return
	insert into DeAn (TenDA, Phong, ChiPhi)
	values (@ten, @phong, @chiphi)
end

go

create proc xoada (@ma int)
as
begin
	if(@ma not in (select MaDA from DeAn)) return

	if(@ma in (select MaDA from PhanCong))
	begin
		delete PhanCong where MaDA = @ma
	end
	delete DeAn where MaDA = @ma
end
go

create proc suada (@ma int, @ten nvarchar(50), @phong int, @chiphi float)
as 
begin
	if(@ma not in (select MaDA from DeAn)) return
	if(LEN(@ten) > 0)
	begin
		update DeAn
		set TenDA = @ten
		where MaDA = @ma
	end
	
	if(@phong = 0)
	begin
		update DeAn 
		set Phong = null
		where MaDA = @ma
	end
	if(@phong not in (select MaNV from NhanVien)) return
	if(@phong != 0)
	begin
		update DeAn 
		set Phong = @phong
		where MaDA = @ma
	end
	if(@chiphi > 0)
	begin
		update DeAn set ChiPhi = @chiphi where MaDA = @ma
	end
end

go
create proc thempc (@mada int, @manv int, @sogio float)
as begin
	if(@mada not in (select MaDA from DeAn)) return
	if(@manv not in (select MaNV from NhanVien)) return
	insert into PhanCong (MaDA, MaNV, SoGio)
	values (@mada, @manv, @sogio)
end

go

create proc suapc (@mada int, @manv int, @sogio float)
as begin
	if(@sogio > 0)
	begin
		update PhanCong
		set SoGio = @sogio
		where MaDA = @mada and MaNV = @manv
	end

end

go

create proc xoapc (@mada int , @manv int)
as begin
	delete PhanCong where MaDA = @mada and MaNV = @manv
end
