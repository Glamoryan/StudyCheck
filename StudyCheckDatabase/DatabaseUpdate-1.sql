use StudyCheck
go
alter table Dersler
alter column guncelleme_tarihi datetime2
go
alter table Dersler
alter column eklenme_tarihi datetime2
go
alter table Roller
alter column rol_kayit_tarihi datetime2
go
alter table Roller
alter column rol_guncelleme_tarihi datetime2
go
alter table Sinavlar
alter column guncelleme_tarihi datetime2
go
alter table Sinavlar
alter column eklenme_tarihi datetime2
go
alter table UyeDetay
alter column guncelleme_tarihi datetime2
go
alter table UyeDetay
alter column kayit_tarihi datetime2