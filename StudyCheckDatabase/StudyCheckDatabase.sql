create database StudyCheck
go
use StudyCheck
go
create table Uyeler
(
id int PRIMARY KEY IDENTITY(1,1),
uye_ad varchar(50) not null,
uye_soyad varchar(50) default('bilinmiyor')
)
go
create table UyeDetay
(
id int PRIMARY KEY IDENTITY(1,1),
uye_id int references Uyeler(id) not null,
--tema_id  int references Temalar(id) default(1),
--rol_id int references Roller(id) not null,
kullanici_adi varchar(20) not null,
kullanici_sifre varchar(30) not null,
kullanici_mail varchar(50) default('bilinmiyor'),
kayit_tarihi datetime not null,
guncelleme_tarihi datetime,
sil_id int default(1) -- 1->aktif 0->pasif
)
go
create table Yetkiler
(
id int PRIMARY KEY IDENTITY(1,1),
yetki_adi varchar(30) not null, -- Okuma , Güncelleme , Silme...
ekleyen_id int references UyeDetay(id),
eklenme_tarihi datetime not null,
sil_id int default(1) -- 1->aktif 0->pasif
)
go
create table Roller
(
id int PRIMARY KEY IDENTITY(1,1),
rol_adi varchar(20) not null,
rol_kayit_tarihi datetime not null,
ekleyen_id int references UyeDetay(id),
rol_guncelleme_tarihi datetime,
sil_id int default(1),
yetki_id int references Yetkiler(id)
)
go
create table Sinavlar
(
id int PRIMARY KEY IDENTITY(1,1),
sinav_ad varchar(30) not null,
sinav_tarih date not null,
eklenme_tarihi datetime not null,
ekleyen_id int references UyeDetay(id),
guncelleme_tarihi datetime,
sil_id int default(1) -- 1->aktif 0->pasif
)
go
create table Dersler
(
id int PRIMARY KEY IDENTITY(1,1),
sinav_id int references Sinavlar(id) not null,
ders_ad varchar(50) not null,
eklenme_tarihi datetime not null,
ekleyen_id int references UyeDetay(id),
guncelleme_tarihi datetime,
sil_id int default(1) -- 1->aktif 0->pasif
)
go
create table Calismalar
(
id int PRIMARY KEY IDENTITY(1,1),
uye_id int references Uyeler(id) not null,
sinav_id int references Sinavlar(id) not null,
ders_id int references Dersler(id) not null,
calisilan_zaman time not null,
calisilan_tarih date not null
)
go
create table Temalar
(
id int PRIMARY KEY IDENTITY(1,1),--1 default
tema_adi varchar(20) not null,
eklenme_tarihi datetime not null,
ekleyen_id int references UyeDetay(id),
sil_id int default(1) -- 1->aktif 0->pasif
)
go
Alter table UyeDetay add tema_id int references Temalar(id)
go
Alter table UyeDetay add rol_id int references Roller(id)