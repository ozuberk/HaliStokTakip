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
    public class SiparisDetayManager : ISiparisDetay
    {
        HaliStokTakipDBEntities db;
        Repository<SiparisDetay> repository;
        public SiparisDetayManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<SiparisDetay>(db);
        }
        public SiparisDetay Bul(int siparisID)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int siparisID, int haliID,string aciklama, bool aktifMi)
        {
            try
            {
                var gnclDetay = repository.BulQuery(s => s.SiparisID == siparisID && s.HaliID == haliID).FirstOrDefault();
                if (gnclDetay == null)
                {
                    return "Sipariş Bulunamadı!";
                }
                
                gnclDetay.Aciklama = aciklama;
                gnclDetay.AktifMi = aktifMi;
                gnclDetay.HaliID = haliID;
                gnclDetay.SiparisID = siparisID;
                int sonuc = repository.Guncelle(gnclDetay);

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

        public string Kaydet(int siparisID, int haliID,string aciklama, bool aktifMi)
        {
            try
            {
                var varMiSiparis = repository.BulQuery(s => s.SiparisID == siparisID && s.HaliID == haliID).FirstOrDefault();
                if (varMiSiparis != null)
                {
                    return "Sipariş Kayıtlı!";
                }
                SiparisDetay detaylar = new SiparisDetay();
               
                detaylar.Aciklama = aciklama;
                detaylar.AktifMi = aktifMi;
                detaylar.HaliID= haliID;
                detaylar.SiparisID= siparisID;

                int sonuc = repository.Kaydet(detaylar);
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

        public IEnumerable<SiparisDetay> SDetayListele()
        {
            return repository.Listele();
        }

        public string Sil(int siparisID, int haliID)
        {
            try
            {
                var pasifSiparis = repository.BulQuery(s => s.SiparisID == siparisID&&s.HaliID==haliID).FirstOrDefault();
                if (pasifSiparis == null)
                {
                    return "Sipariş Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifSiparis.AktifMi == false)
                {
                    return "Sipariş Pasif Durumda";
                }

                pasifSiparis.AktifMi = false;
                int sonuc = repository.Guncelle(pasifSiparis);
                if (sonuc > 0)
                {
                    return "Sipariş Pasif İşlemi Başarılı";
                }
                return "Sipariş Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
