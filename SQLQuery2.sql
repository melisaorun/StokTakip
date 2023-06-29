create proc Listele
as begin
select*from Urunler
end

create proc Ekle
@Kategori varchar(50),
@Marka varchar(50),
@UrunAdi varchar(50),
@Miktar int,
@AlisFiyati int,
@SatisFiyati int
as begin
insert into Urunler (Kategori,Marka,UrunAdi,Miktar,AlisFiyati,SatisFiyati)
values (@Kategori,@Marka,@UrunAdi,@Miktar,@AlisFiyati,@SatisFiyati)
end

create proc Yenile
@BarkodNo int,
@Kategori varchar(50),
@Marka varchar(50),
@UrunAdi varchar(50),
@Miktar int,
@AlisFiyati int,
@SatisFiyati int
as begin
update Urunler set Kategori=@Kategori,Marka=@Marka,UrunAdi=@UrunAdi,Miktar=@Miktar,AlisFiyati=@AlisFiyati,SatisFiyati=@SatisFiyati where BarkodNo=@BarkodNo
end

create proc Sil
@BarkodNo int
as begin
delete from Urunler where BarkodNo=@BarkodNo
end

create proc Ara
@UrunAdi varchar(50)
as begin
select*from Urunler where UrunAdi=@UrunAdi
end

create proc Listele1
as begin
select*from Satislar
end

create proc Ekle1
@TC int,
@AdSoyad varchar(50),
@Telefon int,
@UrunAdi varchar(50),
@Miktar int,
@SatisFiyati int,
@ToplamFiyat int,
@BarkodNo int
as begin
insert into Satislar(TC,AdSoyad,Telefon,UrunAdi,Miktar,SatisFiyati,ToplamFiyat,BarkodNo)
values (@TC,@AdSoyad,@Telefon,@UrunAdi,@Miktar,@SatisFiyati,@ToplamFiyat,@BarkodNo)
end

create proc Yenile1
@SatisNo int,
@TC int,
@AdSoyad varchar(50),
@Telefon int,
@UrunAdi varchar(50),
@Miktar int,
@SatisFiyati int,
@ToplamFiyat int,
@BarkodNo int
as begin
update Satislar set TC=@TC,AdSoyad=@AdSoyad,Telefon=@Telefon,UrunAdi=@UrunAdi,Miktar=@Miktar,SatisFiyati=@SatisFiyati,ToplamFiyat=@ToplamFiyat,BarkodNo=@BarkodNo where SatisNo=@SatisNo
end

create proc Sil1
@SatisNo int
as begin
delete from Satislar where SatisNo=@SatisNo
end

create proc Ara1
@TC int
as begin
select*from Satislar where TC=@TC
end


