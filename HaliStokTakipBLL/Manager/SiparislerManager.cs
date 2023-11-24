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
    public class SiparislerManager : ISiparis
    {
        HaliStokTakipDBEntities db;
        Repository<Siparisler> repository;
        public SiparislerManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<Siparisler>(db);
        }
        public Siparisler Bul(string siparisAdi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int siparislerID, string siparisAdi, int musteriID, DateTime sipariTarihi, DateTime teslimatTarihi, bool siparisDurumu, decimal toplamTutar)
        {
            try
            {
                var guncellenecekSiparis = repository.BulQuery(s => s.ID == siparislerID).FirstOrDefault();
                if (guncellenecekSiparis == null)
                {
                    return "Sipariş Bulunamadı!";
                }
                guncellenecekSiparis.SiparisAdi = siparisAdi;
                guncellenecekSiparis.MusteriID = musteriID;
                guncellenecekSiparis.SiparisTarihi = sipariTarihi;
                guncellenecekSiparis.TeslimatTarihi = teslimatTarihi;
                guncellenecekSiparis.SiparisDurumu = siparisDurumu;
                guncellenecekSiparis.ToplamTutar = toplamTutar;

                int sonuc = repository.Guncelle(guncellenecekSiparis);

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

        public string Kaydet(string siparisAdi, int musteriID, DateTime sipariTarihi, DateTime teslimatTarihi, bool siparisDurumu, decimal toplamTutar)
        {
            try
            {
                var varMiSiparis = repository.BulQuery(s => s.SiparisAdi == siparisAdi).FirstOrDefault();
                if (varMiSiparis != null)
                {
                    return "Sipariş Kayıtlı!";
                }
                Siparisler siparisler = new Siparisler();
                siparisler.SiparisAdi = siparisAdi;
                siparisler.MusteriID = musteriID;
                siparisler.SiparisTarihi = sipariTarihi;
                siparisler.TeslimatTarihi = teslimatTarihi;
                siparisler.SiparisDurumu = siparisDurumu;
                siparisler.ToplamTutar = toplamTutar;

                int sonuc = repository.Kaydet(siparisler);
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

        public string Sil(int siparislerID)
        {
            try
            {
                var pasifSiparis = repository.BulQuery(s => s.ID == siparislerID).FirstOrDefault();
                if (pasifSiparis == null)
                {
                    return "Sipariş Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifSiparis.SiparisDurumu== false)
                {
                    return "Sipariş Pasif Durumda";
                }

                pasifSiparis.SiparisDurumu = false;
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

        public IEnumerable<sp_SiparisListesi_Result> SiparisleriListele()
        {
            return db.sp_SiparisListesi().ToList();
        }
    }
}
