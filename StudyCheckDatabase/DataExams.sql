use StudyCheck
go
insert into Uyeler (uye_ad,uye_soyad) values ('steve','jobs')
go 
insert into UyeDetay (uye_id,kullanici_adi,kullanici_sifre,kullanici_mail,kayit_tarihi,guncelleme_tarihi,sil_id)
values (1,'admin','admin123','steve@mail',GETDATE(),GETDATE(),1)
go
insert into Sinavlar (sinav_ad,sinav_tarih,eklenme_tarihi,ekleyen_id,guncelleme_tarihi,sil_id)
values ('dgs',GETDATE(),GETDATE(),1,GETDATE(),1)
go
insert into Dersler (sinav_id,ders_ad,eklenme_tarihi,ekleyen_id,guncelleme_tarihi,sil_id) values (1,'matematik',GETDATE(),1,GETDATE(),1)
go
insert into Yetkiler (yetki_adi,ekleyen_id,eklenme_tarihi,sil_id) values ('Full',1,GETDATE(),1)
go
insert into Roller (rol_adi,rol_kayit_tarihi,ekleyen_id,rol_guncelleme_tarihi,sil_id,yetki_id) 
values ('admin',GETDATE(),1,GETDATE(),1,1)
go
insert into Temalar (tema_adi,eklenme_tarihi,ekleyen_id,sil_id) values ('default',GETDATE(),1,1)
go
update UyeDetay set rol_id = 1, tema_id=1 where id = 1
