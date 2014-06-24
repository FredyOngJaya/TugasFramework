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
	tipe varchar(10) not null,
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
	nomor_identitas varchar(64) not null,
	nama varchar(255) not null,
	jenis_kelamin varchar(10) not null,
	alamat varchar(255) not null,
	hp varchar(16) not null,
	--status_aktif bit not null default 1,
	constraint PK_Anggota primary key (id),
	constraint UQ_Anggota unique (nomor_identitas)
)
go

create table Peminjaman_Buku
(
	id int identity(1,1),
	id_anggota int,
	id_buku int,
	tanggal_pinjam datetime not null,
	sudah_kembali bit not null default 0,
	tanggal_kembali datetime,
	constraint PK_Peminjaman_Buku_Detail primary key (id),
	constraint FK_Peminjaman_Buku_Detail_ref_Anggota foreign key (id_anggota)
		references Anggota (id),
	constraint FK_Peminjaman_Buku_Detail_ref_Buku foreign key (id_buku)
		references Buku (id)
)
go

insert into Pengguna
--select 'ADMIN', CONVERT(varchar(50), HASHBYTES('SHA1', 'spasi'), 2)
select 'admin', master.dbo.fn_varbintohexsubstring(0, HashBytes('SHA1', 'spasi'), 1, 0), 'private'
union select 'member', master.dbo.fn_varbintohexsubstring(0, HashBytes('SHA1', 'member'), 1, 0), 'public'
go
/*
insert into Anggota
select * from (
select '1' a,'stanley' b,'alamat tak jelas' c,'080000000000' d,1 e
union select '2','ong','alamat tak jelas','080000000000',1
union select '3','darwin','alamat tak jelas','080000000000',1
union select '4','acek','alamat tak jelas','080000000000',1
union select '5','tom','alamat tak jelas','080000000000',1
union select '6','her','alamat tak jelas','080000000000',1
) a
go
*/
insert into Buku
select * from (
select 'buku1' a
union select 'buku2'
union select 'buku3'
union select 'buku4'
union select 'buku5'
) a
go

insert into Pengarang
select * from (
select 'pengarang1' a
union select 'pengarang2'
union select 'pengarang3'
union select 'pengarang4'
union select 'pengarang5'
) a
go

insert into Pengarang_Buku
select * from (
select 1 a, 1 b
union select 2, 1
union select 2, 2
union select 2, 3
union select 3, 3
union select 4, 4
union select 4, 5
union select 5, 5
) a
go