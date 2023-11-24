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

    public class RenklerManager : IRenkler
    {
        HaliStokTakipDBEntities db;
        Repository<Renkler> repository;
        public RenklerManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<Renkler>(db);
        }

        public Renkler Bul(string renkAdi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int renklerID, string renkAdi, bool aktifMi, string aciklama)
        {
            try
            {
                var guncellenecekRenk = repository.BulQuery(r => r.ID == renklerID).FirstOrDefault();
                if (guncellenecekRenk == null)
                {
                    return "Renk Bulunamadı!";
                }
                guncellenecekRenk.RenkAdi = renkAdi;
                guncellenecekRenk.AktifMi = aktifMi;
                guncellenecekRenk.Aciklama = aciklama;

                int sonuc = repository.Guncelle(guncellenecekRenk);

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

        public string Kaydet(string renkAdi, bool aktifMi, string aciklama)
        {
            try
            {
                var varMiRenk = repository.BulQuery(r => r.RenkAdi == renkAdi).FirstOrDefault();
                if (varMiRenk != null)
                {
                    return "Renk Kayıtlı!";
                }
                Renkler renkler = new Renkler();
                renkler.RenkAdi = renkAdi;
                renkler.AktifMi = aktifMi;
                renkler.Aciklama = aciklama;

                int sonuc = repository.Kaydet(renkler);
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

        public IEnumerable<Renkler> RenkleriListele()
        {
            return repository.Listele();
        }

        public string Sil(int renklerID)
        {
            try
            {
                var pasifRenk = repository.BulQuery(r => r.ID == renklerID).FirstOrDefault();
                if (pasifRenk == null)
                {
                    return "Renk Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifRenk.AktifMi == false)
                {
                    return "Renk Pasif Durumda";
                }

                pasifRenk.AktifMi = false;
                int sonuc = repository.Guncelle(pasifRenk);
                if (sonuc > 0)
                {
                    return "Renk Pasif İşlemi Başarılı";
                }
                return "Renk Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
