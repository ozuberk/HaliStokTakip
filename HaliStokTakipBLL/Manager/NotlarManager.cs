using HaliStokTakipBLL.Interface;
using HaliStokTakipDLL.RepositoryFolder;
using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Manager
{
    public class NotlarManager : INotlar
    {
        HaliStokTakipDBEntities db;
        Repository<Notlar> repository;
        public NotlarManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<Notlar>(db);
        }

        public Notlar Bul(int kullaniciID, DateTime notTarihi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int notlarID, int kullaniciID, DateTime notTarihi, string notIcerigi, bool aktifMi)
        {
            try
            {
                var guncellenecekNot = repository.BulQuery(n => n.ID == notlarID).FirstOrDefault();
                if (guncellenecekNot == null)
                {
                    return "Not Bulunamadı!";
                }
                guncellenecekNot.KullaniciID = kullaniciID;
                guncellenecekNot.NotTarihi = notTarihi;
                guncellenecekNot.NotIcerigi = notIcerigi;
                guncellenecekNot.AktifMi = aktifMi;

                int sonuc = repository.Guncelle(guncellenecekNot);

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

        public string Kaydet(int kullaniciID, DateTime notTarihi, string notIcerigi, bool aktifMi)
        {
            try
            {
                var varMiNot = repository.BulQuery(n => n.KullaniciID == kullaniciID && n.NotTarihi == notTarihi).FirstOrDefault();
                if (varMiNot != null)
                {
                    return "Kullanıcı aynı tarihte birden fazla not ekleyemez.";
                }
                Notlar notlar = new Notlar();
                notlar.KullaniciID = kullaniciID;
                notlar.NotTarihi = notTarihi;
                notlar.NotIcerigi = notIcerigi;
                notlar.AktifMi = aktifMi;

                int sonuc = repository.Kaydet(notlar);
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

        public IEnumerable<sp_NotListesi_Result> NotlariListele()
        {
            return db.sp_NotListesi().ToList();
        }

        public string Sil(int notlarID)
        {
            try
            {
                var pasifNot = repository.BulQuery(n => n.ID == notlarID).FirstOrDefault();
                if (pasifNot == null)
                {
                    return "Not Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifNot.AktifMi == false)
                {
                    return "Not Pasif Durumda";
                }

                pasifNot.AktifMi = false;
                int sonuc = repository.Guncelle(pasifNot);
                if (sonuc > 0)
                {
                    return "Not Pasif İşlemi Başarılı";
                }
                return "Not Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
