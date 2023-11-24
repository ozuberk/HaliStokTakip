--HALI LÝSTESÝ

go
create Procedure sp_HaliListesi
as
begin
select
h.ID,
h.HaliAdi,
k.KategoriAdi,
m.MarkaAdi,
r.RenkAdi,
d.DesenAdi,
b.BoyutAdi,
h.BarkodNo,
h.Fiyat,
h.Aciklama,
h.UretimTarihi,
h.AktifMi
from	Halilar as h
join	Kategoriler as k on h.KategoriID=k.ID
join	Markalar as m on h.MarkaID=m.ID
join	Renkler as r on h.KategoriID=r.ID
join	Desenler as d on h.KategoriID=d.ID
join	Boyutlar as b on h.KategoriID=b.ID
end
go


--DESEN LÝSTESÝ
go
create Procedure sp_DesenListesi
as
begin
select
d.ID,
d.DesenAdi,
d.Aciklama,
d.AktifMi
from	Desenler as d
join	Halilar as h on d.ID=h.DesenID
end
go

--Boyut LÝSTESÝ
go
alter Procedure sp_BoyutListesi
as
begin
select
b.ID,
b.BoyutAdi,
b.Eni,
b.Boyu,
b.Alani,
b.AktifMi
from	Boyutlar as b
join	Halilar as h on b.ID=h.BoyutID
end
go

--Renk LÝSTESÝ
go
alter Procedure sp_RenkListesi
as
begin
select
r.ID,
r.RenkAdi,
r.Aciklama,
r.AktifMi
from	Renkler as r
join	Halilar as h on r.ID=h.RenkID
end
go


--Marka LÝSTESÝ
go
alter Procedure sp_MarkaListesi
as
begin
select
m.ID,
m.MarkaAdi,
m.Aciklama,
m.AktifMi
from	Markalar as m
join	Halilar as h on m.ID=h.MarkaID
end
go


--Kategoriler LÝSTESÝ
go
alter Procedure sp_KategoriListesi
as
begin
select
k.ID,
k.KategoriAdi,
k.Aciklama,
k.AktifMi
from	Kategoriler as k
join	Halilar as h on k.ID=h.KategoriID
end
go



--Sipariþler Listesi
go
create Procedure sp_SiparisListesi
as
begin
select
s.ID,
s.SiparisAdi,
m.Adi,
s.ToplamTutar,
s.SiparisTarihi,
s.TeslimatTarihi,
s.SiparisDurumu,
sd.Aciklama,
h.HaliAdi
from	Siparisler as s
join	SiparisDetay as sd on s.ID=sd.SiparisID
join	Musteriler as m on s.MusteriID=m.ID
join	Halilar as h on sd.HaliID=h.ID
end
go

--SiparisÖdeme LÝSTESÝ
go
create Procedure sp_OdemeListesi
as
begin
select
so.ID,
s.SiparisAdi,
so.OdemeTarihi,
so.OdemeYontemi,
so.AktifMi
from	SiparisOdeme as so
join	Siparisler as s on so.SiparisID=s.ID
end
go

--Ýade LÝSTESÝ
go
create Procedure sp_IadeListesi
as
begin
select
i.ID,
s.SiparisAdi,
i.IadeTarihi,
i.IadeNedeni,
i.IadeOnayDurumu
from	Iadeler as i
join	Siparisler as s on i.SiparisID=s.ID
end
go


--Kargolar LÝSTESÝ
go
create Procedure sp_KargoListesi
as
begin
select
k.ID,
s.SiparisAdi,
k.FirmaAdi,
k.TakipKodu,
k.TahminiTeslimTarihi,
k.TeslimTarihi,
k.AktifMi,
k.Aciklama
from	KargoTakip as k
join	Siparisler as s on k.SiparisID=s.ID
end
go

--Müþteriler LÝSTESÝ
go
create Procedure sp_MusteriListesi
as
begin
select
m.ID,
m.Adi,
m.Adresi,
m.Telefon,
m.Email,
m.VergiNo,
m.Aciklama,
m.AktifMi
from	Musteriler as m
join	Siparisler as s on m.ID=s.MusteriID
end
go


--Stoklar LÝSTESÝ
go
create Procedure sp_StokListesi
as
begin
select
s.ID,
s.StokAdi,
h.HaliAdi,
s.StokMiktari,
s.Aciklama,
s.AktifMi
from	Stoklar as s
join	Halilar as h on s.HaliID=h.ID
end
go

--Kullanici LÝSTESÝ
go
create Procedure sp_KullaniciListesi
as
begin
select
k.ID,
k.KullaniciAdi,
k.KullaniciSifre,
k.KullaniciEmail,
y.YetkiAdi,
k.Aciklama,
k.AktifMi
from	Kullanicilar as k
join	Yetkiler as y on k.YetkiID=y.ID
end
go


--Yetki LÝSTESÝ
go
create Procedure sp_YetkiListesi
as
begin
select
y.ID,
y.YetkiAdi,
y.Aciklama,
y.AktifMi
from	Kullanicilar as k
join	Yetkiler as y on k.YetkiID=y.ID
end
go


--Not LÝSTESÝ
go
create Procedure sp_NotListesi
as
begin
select
n.ID,
k.KullaniciAdi,
n.NotTarihi,
n.NotIcerigi,
n.AktifMi
from	Notlar as n
join	Kullanicilar as k on n.KullaniciID=k.ID
end
go