use master
go

if exists(select name from sys.databases where name=N'library')
begin
	alter database library set single_user with rollback immediate;
	drop database Library;
end
go

create database Library
go

use Library
go

create table Pengguna
(
	username varchar(64) not null,
	fingerprint varchar(50) not null,
	constraint PK_Pengguna primary key (username)
)
go

create table Buku
(
	id int identity(1,1),
	judul varchar(255) not null,
	constraint PK_Buku primary key (id)
)
go

create table Pengarang
(
	id int identity(1,1),
	nama varchar(255) not null,
	constraint PK_Pengarang primary key (id)
)
go

create table Pengarang_Buku
(
	id_buku int,
	id_pengarang int,
	constraint FK_Pengarang_Buku_ref_Buku foreign key (id_buku)
		references Buku (id),
	constraint PK_Pengarang_Buku_ref_Pengarang foreign key (id_pengarang)
		references Pengarang (id)
)
go

create table Anggota
(
	id int identity(1,1),
	nama varchar(255) not null,
	constraint PK_Anggota primary key (id)
)
go

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
go

insert into Pengguna
--select 'ADMIN', CONVERT(varchar(50), HASHBYTES('SHA1', 'spasi'), 2)
select 'ADMIN', master.dbo.fn_varbintohexsubstring(0, HashBytes('SHA1', 'spasi'), 1, 0)
go

insert into anggota
select * from (
select 'stanley' a
union select 'ong'
union select 'darwin'
union select 'acek'
union select 'tom'
union select 'her'
) a
go