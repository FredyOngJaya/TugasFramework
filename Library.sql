create database Library
go

use Library
go

create table Buku
(
	id int identity(1,1),
	nama varchar(255) not null,
	constraint PK_Buku primary key (id)
)

create table Pengarang
(
	id int identity(1,1),
	nama varchar(255) not null,
	constraint PK_Pengarang primary key (id)
)

create table Pengarang_Buku
(
	id_buku int,
	id_pengarang int,
	constraint FK_Pengarang_Buku_ref_Buku foreign key (id_buku)
		references Buku (id),
	constraint PK_Pengarang_Buku_ref_Pengarang foreign key (id_pengarang)
		references Pengarang (id)
)

create table Anggota
(
	id int identity(1,1),
	nama varchar(255) not null,
	constraint PK_Anggota primary key (id)
)

create table Peminjaman_Buku
(
	id int identity(1,1),
	id_anggota int,
	id_buku int,
	tanggal_pinjam datetime not null,
	sudah_kembali bit not null default 0,
	tanggal_kembali datetime not null,
	constraint PK_Peminjaman_Buku_Detail primary key (id),
	constraint FK_Peminjaman_Buku_Detail_ref_Anggota foreign key (id_anggota)
		references Anggota (id),
	constraint FK_Peminjaman_Buku_Detail_ref_Buku foreign key (id_buku)
		references Buku (id)
)