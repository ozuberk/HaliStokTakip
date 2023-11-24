using HaliStokTakipDLL.RepositoryFolder;
using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaliStokTakipBLL.Interface;

namespace HaliStokTakipBLL.Manager
{
    public class OdemelerManager :IOdemeler
    {
        HaliStokTakipDBEntities db;
        Repository<SiparisOdeme> repository;
        public OdemelerManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<SiparisOdeme>(db);
        }
        public SiparisOdeme Bul(int odemeID)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int odemeID, int siparisID, DateTime odemeTarihi, string odemeYontemi, bool aktifMi)
        {
            try
            {
                var guncelleOdeme = repository.BulQuery(o => o.ID == odemeID).FirstOrDefault();
                if (guncelleOdeme == null)
                {
                    return "Data Bulunamadı!";
                }
                guncelleOdeme.SiparisID = siparisID;
                guncelleOdeme.OdemeTarihi = odemeTarihi;
                guncelleOdeme.OdemeYontemi = odemeYontemi;
                guncelleOdeme.AktifMi = aktifMi;

                int sonuc = repository.Guncelle(guncelleOdeme);

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

        public IEnumerable<sp_OdemeListesi_Result> OdemeleriListele()
        {
            return db.sp_OdemeListesi().ToList();
        }

        public string Kaydet(int siparisID, DateTime odemeTarihi, string odemeYontemi, bool aktifMi)
        {
            try
            {
                var varMiOdeme = repository.BulQuery(o => o.SiparisID == siparisID).FirstOrDefault();
                if (varMiOdeme != null)
                {
                    return "Ödeme Girişi Kayıtlı!";
                }
                SiparisOdeme odemeler = new SiparisOdeme();
                odemeler.SiparisID = siparisID;
                odemeler.OdemeTarihi = odemeTarihi;
                odemeler.OdemeYontemi = odemeYontemi;
                odemeler.AktifMi = aktifMi;

                int sonuc = repository.Kaydet(odemeler);
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

        public string Sil(int odemeID)
        {
            try
            {
                var pasifOdeme = repository.BulQuery(o => o.ID == odemeID).FirstOrDefault();
                if (pasifOdeme == null)
                {
                    return "Ödeme Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifOdeme.AktifMi == false)
                {
                    return "Ödeme Pasif Durumda";
                }

                pasifOdeme.AktifMi = false;
                int sonuc = repository.Guncelle(pasifOdeme);
                if (sonuc > 0)
                {
                    return "Ödeme Pasif İşlemi Başarılı";
                }
                return "Ödeme Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
