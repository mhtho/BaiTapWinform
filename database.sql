CREATE DATABASE QuanLyPhanMemThi
GO

USE QuanLyPhanMemThi
Go

-- HocSinh

-- GiaoVien
-- TaiKhoanDangNhap
-- DeThi
-- ChiTiet_DeThi
-- CauHoi_TracNghiem
-- CauHoi_TuLuan
-- KetQua

CREATE TABLE HocSinh (
	maHocSinh int IDENTITY PRIMARY KEY,
	hoTen nvarchar(100) NOT NULL,
	ngaySinh date,
	email varchar(100)
)
GO



CREATE TABLE GiaoVien (
	maGiaoVien int IDENTITY PRIMARY KEY,
	hoTen nvarchar(100) NOT NULL,
	email varchar(100),
	soDienThoai varchar(10)
)
GO


CREATE TABLE taikhoan (
    tenDangNhap NVARCHAR(100) PRIMARY KEY,
    matKhau NVARCHAR(100) NOT NULL,
    maNguoiDung INT NOT NULL,
    loaiNguoiDung NVARCHAR(50) NOT NULL,
    FOREIGN KEY (maNguoiDung) REFERENCES dbo.HocSinh(maHocSinh),
    FOREIGN KEY (maNguoiDung) REFERENCES dbo.GiaoVien(maGiaoVien),
    CONSTRAINT CK_LoaiNguoiDung CHECK (loaiNguoiDung IN ('HocSinh', 'GiaoVien'))
)
GO


CREATE TABLE DeThi (
	maDeThi int IDENTITY PRIMARY KEY,
	maGiaoVien int NOT NULL,
	tenDeThi nvarchar(100) NOT NULL DEFAULT N'...',
	thoiGianLamBai int NOT NULL  DEFAULT 45, -- So phut lam bai
	monThi nvarchar(100) NOT NULL DEFAULT N'Văn',
	diemToiDa float NOT NULL DEFAULT 10,
	FOREIGN KEY (maGiaoVien) REFERENCES dbo.GiaoVien(maGiaoVien)
)
GO

CREATE TABLE CauHoiTracNghiem (
	maCauHoi int IDENTITY PRIMARY KEY,
	noiDung nvarchar(MAX) NOT NULL DEFAULT N'...',
	dapAn1 nvarchar(MAX) NOT NULL DEFAULT N'...',
	dapAn2 nvarchar(MAX) NOT NULL DEFAULT N'...',
	dapAn3 nvarchar(MAX) NOT NULL DEFAULT N'...',
	dapAn4 nvarchar(MAX) NOT NULL DEFAULT N'...',
	cauTraLoi int NOT NULL DEFAULT 1
)
GO

CREATE TABLE CauHoiTuLuan (
	maCauHoi int IDENTITY PRIMARY KEY,
	noiDung nvarchar(MAX) NOT NULL DEFAULT N'...',
	cauTraLoi nvarchar(MAX) NOT NULL DEFAULT N'...'
)
GO

CREATE TABLE ChiTiet_DeThi (
	maChiTietDeThi int IDENTITY PRIMARY KEY,
	maDeThi int NOT NULL,
	maCauHoiTN int,
	maCauHoiTL int,
	FOREIGN KEY (maDeThi) REFERENCES dbo.DeThi(maDeThi),
	FOREIGN KEY (maCauHoiTN) REFERENCES dbo.CauHoiTracNghiem(maCauHoi),
	FOREIGN KEY (maCauHoiTL) REFERENCES dbo.CauHoiTuLuan(maCauHoi)
)
GO

CREATE TABLE KetQua (
	maKetQua int IDENTITY PRIMARY KEY,
	maHocSinh int NOT NULL,
	maDeThi int NOT NULL,
	diem float NOT NULL,
	thoiGianNop datetime NOT NULL,
	FOREIGN KEY (maHocSinh) REFERENCES dbo.HocSinh(maHocSinh),
	FOREIGN KEY (maDeThi) REFERENCES dbo.DeThi(maDeThi)
)
GO
-- Thêm dữ liệu vào bảng HocSinh
INSERT INTO HocSinh (hoTen, ngaySinh, email)
VALUES 
('Nguyen Van An', '2005-01-15', 'nguyenvana@example.com'),
('Tran Thi Bich', '2006-07-25', 'tranthib@example.com'),
('Le Van Chau', '2005-12-10', 'levanc@example.com');
GO
-- Thêm dữ liệu vào bảng GiaoVien
INSERT INTO GiaoVien (hoTen, email, soDienThoai)
VALUES 
('Pham Van Dung', 'phamvand@example.com', '0901234567'),
('Nguyen Thi Yen', 'nguyenthie@example.com', '0912345678');
GO
-- Thêm dữ liệu vào bảng TaiKhoan
INSERT INTO taikhoan (tenDangNhap, matKhau, maNguoiDung, loaiNguoiDung)
VALUES 
('hs1', 'password123', 1, 'HocSinh'),
('hs2', 'password456', 2, 'HocSinh'),
('gv1', 'password789', 1, 'GiaoVien');
GO
-- Thêm dữ liệu vào bảng DeThi
INSERT INTO DeThi (maGiaoVien, tenDeThi)
VALUES 
(1, N'Đề kiểm tra Văn số 1'),
(2, N'Đề kiểm tra Văn số 2');
GO
-- Thêm dữ liệu vào bảng CauHoiTracNghiem
INSERT INTO CauHoiTracNghiem (noiDung, dapAn1, dapAn2, dapAn3, dapAn4, cauTraLoi)
VALUES

(N'Tác giả của bài thơ "Tràng giang" là ai?', 
 N'Hàn Mặc Tử', N'Huy Cận', N'Tố Hữu', N'Xuân Diệu', 2),
 
(N'Trong bài thơ "Sóng" của Xuân Quỳnh, hình ảnh "sóng" là biểu tượng cho điều gì?', 
 N'Tình yêu mãnh liệt', N'Tự do', N'Nỗi buồn', N'Khát vọng', 1),

(N'Tác phẩm "Chí Phèo" thuộc thể loại nào?', 
 N'Truyện ngắn', N'Tiểu thuyết', N'Truyện vừa', N'Truyện cổ tích', 3),

(N'Câu thơ: "Rừng xanh hoa chuối đỏ tươi/ Đèo cao nắng ánh dao gài thắt lưng" thuộc bài thơ nào?', 
 N'Tiếng hát con tàu', N'Tây Tiến', N'Việt Bắc', N'Đất Nước', 2),

(N'Nội dung chính của bài "Vội vàng" là gì?', 
 N'Tình yêu quê hương đất nước', 
 N'Tình yêu đôi lứa và khát vọng sống mãnh liệt', 
 N'Lòng tự hào về thiên nhiên tươi đẹp', 
 N'Tư tưởng cách mạng trong thơ', 2),

(N'Tác phẩm nào được viết bởi Nguyễn Du?', 
 N'Truyện Kiều', N'Lục Vân Tiên', N'Chinh phụ ngâm', N'Bạch Đằng giang phú', 1),

(N'Tác giả của bài thơ "Nhớ rừng" là ai?', 
 N'Nguyễn Đình Thi', N'Tố Hữu', N'Tế Hanh', N'Thế Lữ', 4),

(N'Trong bài "Đất nước" của Nguyễn Khoa Điềm, "Đất nước" được định nghĩa qua hình ảnh nào?', 
 N'Hình ảnh con người cần cù lao động', 
 N'Hình ảnh những câu chuyện cổ tích', 
 N'Hình ảnh núi sông và văn hóa dân gian', 
 N'Hình ảnh anh hùng trong chiến tranh', 3),

(N'Câu nói "Ai về nhắn với bạn nguồn/Cành dâu cành bể ai buồn hơn ai" thuộc bài nào?', 
 N'Bên kia sông Đuống', 
 N'Thiếu nữ bên sông Lô', 
 N'Đất nước', 
 N'Quê hương', 1),

(N'Tác giả của tập thơ "Từ ấy" là ai?', 
 N'Xuân Diệu', N'Tố Hữu', N'Chế Lan Viên', N'Huy Cận', 2);

GO
-- Thêm dữ liệu vào bảng CauHoiTuLuan
INSERT INTO CauHoiTuLuan (noiDung, cauTraLoi)
VALUES
(N'Phân tích hình tượng người lính Tây Tiến trong bài thơ "Tây Tiến" của Quang Dũng.', 
 N'Bi tráng, lãng mạn.'),

(N'Nêu ý nghĩa của hình tượng "sóng" trong bài thơ "Sóng" của Xuân Quỳnh.', 
 N'Tình yêu mãnh liệt.'),

(N'Phân tích nhân vật Chí Phèo trong truyện ngắn "Chí Phèo" của Nam Cao.', 
 N'Nông dân tha hóa.'),

(N'Nêu cảm nhận của em về bài thơ "Vội vàng" của Xuân Diệu.', 
 N'Khát vọng sống.'),

(N'Phân tích vai trò của các câu ca dao trong đoạn trích "Đất Nước" của Nguyễn Khoa Điềm.', 
 N'Vẻ đẹp văn hóa.'),

(N'Viết đoạn văn trình bày suy nghĩ của em về tư tưởng nhân đạo trong "Truyện Kiều" của Nguyễn Du.', 
 N'Đề cao con người.'),

(N'Phân tích ý nghĩa biểu tượng "rừng" trong bài thơ "Nhớ rừng" của Thế Lữ.', 
 N'Khát vọng tự do.'),

(N'Trình bày ý nghĩa của hai câu thơ: "Khi ta lớn lên Đất Nước đã có rồi/ Đất Nước có trong những cái ngày xửa ngày xưa..." của Nguyễn Khoa Điềm.', 
 N'Đất Nước trường tồn.'),

(N'Phân tích tâm trạng của người mẹ trong bài thơ "Khúc hát ru những em bé lớn trên lưng mẹ" của Nguyễn Khoa Điềm.', 
 N'Yêu con, yêu quê.'),

(N'Nêu cảm nhận của em về vẻ đẹp thiên nhiên Tây Bắc trong bài thơ "Tây Tiến" của Quang Dũng.', 
 N'Hùng vĩ, thơ mộng.');

GO
-- Thêm dữ liệu vào bảng ChiTiet_DeThi
INSERT INTO ChiTiet_DeThi (maDeThi, maCauHoiTN, maCauHoiTL)
VALUES 
--DE 1
(1, 1, NULL),
(1,2 , NULL),
(1,3,NULL),
(1,4,NULL),
(1,5,NULL),
(1,NULL,1),
(1,NULL,2),
(1,NULL,3),

--DE 2
(2,6,NULL),
(2,7,NULL),
(2,8,NULL),
(2,9,NULL),
(2,10,NULL),
(2,NULL,7),
(2,NULL,8),
(2,NULL,9),
(2,NULL,10);

GO
-- Thêm dữ liệu vào bảng KetQua
INSERT INTO KetQua (maHocSinh, maDeThi, diem, thoiGianNop)
VALUES 
(1, 1, 8.5, '2024-11-28 09:15:00'),
(2, 1, 7.0, '2024-11-28 09:45:00'),
(1, 2, 9.0, '2024-11-28 10:30:00');



