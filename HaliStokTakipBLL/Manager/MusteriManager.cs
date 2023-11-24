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
    public class MusteriManager : IMusteri
    {
        HaliStokTakipDBEntities db;
        Repository<Musteriler> repository;
        public MusteriManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<Musteriler>(db);
        }

        public Musteriler Bul(string adi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int musterilerID, string adi, string adresi, string telefon, string email, string vergiNo, string aciklama, bool aktifMi)
        {
            try
            {
                var guncellenecekMusteri = repository.BulQuery(m => m.ID == musterilerID).FirstOrDefault();
                if (guncellenecekMusteri == null)
                {
                    return "Müşteri Bulunamadı!";
                }
                guncellenecekMusteri.Adi = adi;
                guncellenecekMusteri.Adresi= adresi;
                guncellenecekMusteri.Telefon = telefon;
                guncellenecekMusteri.Email = email;
                guncellenecekMusteri.VergiNo = vergiNo;
                guncellenecekMusteri.Aciklama = aciklama;
                guncellenecekMusteri.AktifMi = aktifMi;

                int sonuc = repository.Guncelle(guncellenecekMusteri);

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

        public string Kaydet(string adi, string adresi, string telefon, string email, string vergiNo, string aciklama, bool aktifMi)
        {
            try
            {
                var varMiMusteri = repository.BulQuery(m => m.Adi == adi&&m.Adresi==adresi&&m.Telefon==telefon).FirstOrDefault();
                if (varMiMusteri != null)
                {
                    return "Musteri Kayıtlı!";
                }
                Musteriler musteriler = new Musteriler();
                musteriler.Adi = adi;
                musteriler.Adresi = adresi;
                musteriler.Telefon = telefon;
                musteriler.Email = email;
                musteriler.VergiNo = vergiNo;
                musteriler.Aciklama = aciklama;
                musteriler.AktifMi = aktifMi;

                int sonuc = repository.Kaydet(musteriler);
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

        public IEnumerable<Musteriler> MusteriListele()
        {
            return repository.Listele();
        }

        public string Sil(int musterilerID)
        {
            try
            {
                var pasifMusteri = repository.BulQuery(m => m.ID == musterilerID).FirstOrDefault();
                if (pasifMusteri == null)
                {
                    return "Müşteri Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifMusteri.AktifMi == false)
                {
                    return "Müşteri Pasif Durumda";
                }

                pasifMusteri.AktifMi = false;
                int sonuc = repository.Guncelle(pasifMusteri);
                if (sonuc > 0)
                {
                    return "Müşteri Pasif İşlemi Başarılı";
                }
                return "Müşteri Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
