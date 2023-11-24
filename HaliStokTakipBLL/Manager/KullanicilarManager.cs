using HaliStokTakipBLL.Interface;
using HaliStokTakipDLL;
using HaliStokTakipDLL.RepositoryFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Manager
{
    public class KullanicilarManager : IKullanici
    {
        HaliStokTakipDBEntities db;
        Repository<Kullanicilar> repository;
        public KullanicilarManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<Kullanicilar>(db);
        }

        public Kullanicilar Bul(string kullaniciAdi)
        {
            throw new NotImplementedException();
        }

        public Kullanicilar Giris(string kullaniciAdi, string sifre)
        {
            var girisDurumu = repository.BulQuery(k => k.KullaniciAdi == kullaniciAdi && k.KullaniciSifre == sifre).FirstOrDefault();
            return girisDurumu;
        }

        public string Guncelle(int kullaniciID, string kullaniciAdi, string kullaniciSifre, string email, int yetkiID, string aciklama, bool aktifMi)
        {
            try
            {
                var guncellenecekKullanici = repository.BulQuery(k => k.ID == kullaniciID).FirstOrDefault();
                if (guncellenecekKullanici == null)
                {
                    return "Kullanıcı Bulunamadı!";
                }
                guncellenecekKullanici.KullaniciAdi = kullaniciAdi;
                guncellenecekKullanici.KullaniciSifre = kullaniciSifre;
                guncellenecekKullanici.KullaniciEmail = email;
                guncellenecekKullanici.YetkiID = yetkiID;
                guncellenecekKullanici.Aciklama = aciklama;
                guncellenecekKullanici.AktifMi = aktifMi;

                int sonuc = repository.Guncelle(guncellenecekKullanici);

                if (sonuc > 0)
                {
                    return "Güncelleme Başarılı";
                }
                return "Güncelleme Başarısız.";
            }
            catch (Exception ex)
            {
                return "Güncelleme Esnasında Bir Hata Oluştur \nHATA: " + ex.Message;
            }
        }

        public string Kaydet(string kullaniciAdi, string kullaniciSifre, string email, int yetkiID, string aciklama, bool aktifMi)
        {
            try
            {
                var varMiKullanici = repository.BulQuery(k => k.KullaniciAdi == kullaniciAdi).FirstOrDefault();
                if (varMiKullanici != null)
                {
                    return "Kullanıcı Kayıtlı!";
                }
                Kullanicilar kullanicilar = new Kullanicilar();
                kullanicilar.KullaniciAdi = kullaniciAdi;
                kullanicilar.KullaniciSifre = kullaniciSifre;
                kullanicilar.KullaniciEmail = email;
                kullanicilar.YetkiID = yetkiID;
                kullanicilar.Aciklama = aciklama;
                kullanicilar.AktifMi = aktifMi; ;

                int sonuc = repository.Kaydet(kullanicilar);
                if (sonuc > 0)
                {
                    return "Kayıt Başarılı";
                }
                return "Kayıt Başarısız";
            }
            catch (Exception ex)
            {
                return "Kayıt Esnasında Bir Hata Oluştu \nHATA: " + ex.Message;
            }
        }

        public IEnumerable<sp_KullaniciListesi_Result> KullaniciListele()
        {
            return db.sp_KullaniciListesi().ToList();
        }

        public string Sil(int kullaniciID)
        {
            try
            {
                var pasifKullanici = repository.BulQuery(k => k.ID == kullaniciID).FirstOrDefault();
                if (pasifKullanici == null)
                {
                    return "Kullanıcı Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifKullanici.AktifMi == false)
                {
                    return "Kullanıcı Pasif Durumda";
                }

                pasifKullanici.AktifMi = false;
                int sonuc = repository.Guncelle(pasifKullanici);
                if (sonuc > 0)
                {
                    return "Kullanıcı Pasif İşlemi Başarılı";
                }
                return "Kullanıcı Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }

        public int Yetki(string kullaniciAdi, string sifre)
        {
            var yetki = repository.BulQuery(k => k.KullaniciAdi == kullaniciAdi && k.KullaniciSifre == sifre).FirstOrDefault().YetkiID;
            return yetki;
        }
    }
}
