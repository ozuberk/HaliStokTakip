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
    public class HalilarManager : IHali
    {
        HaliStokTakipDBEntities db;
        Repository<Halilar> repository;
        public HalilarManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<Halilar>(db);
        }
        public Halilar Bul(string haliAdi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int halilarID, int kategoriID, int markaID, int renkID, int desenID, int boyutID, string barkodNo, string haliAdi, decimal fiyat, string aciklama, DateTime uretimTarihi, bool aktifMi)
        {
            try
            {
                var guncellenecekHali = repository.BulQuery(h => h.ID == halilarID).FirstOrDefault();
                if (guncellenecekHali == null)
                {
                    return "Halı Bulunamadı!";
                }
                guncellenecekHali.KategoriID = kategoriID;
                guncellenecekHali.MarkaID = markaID;
                guncellenecekHali.RenkID = renkID;
                guncellenecekHali.DesenID = desenID;
                guncellenecekHali.BoyutID = boyutID;
                guncellenecekHali.BarkodNo = barkodNo;
                guncellenecekHali.HaliAdi = haliAdi;
                guncellenecekHali.Fiyat = fiyat;
                guncellenecekHali.Aciklama = aciklama;
                guncellenecekHali.UretimTarihi = uretimTarihi;
                guncellenecekHali.AktifMi = aktifMi;

                int sonuc = repository.Guncelle(guncellenecekHali);

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

        public IEnumerable<sp_HaliListesi_Result> HalilariListele()
        {
            return db.sp_HaliListesi().ToList();
        }

        public string Kaydet(int kategoriID, int markaID, int renkID, int desenID, int boyutID, string barkodNo, string haliAdi, decimal fiyat, string aciklama, DateTime uretimTarihi, bool aktifMi)
        {
            try
            {
                var varMiHali = repository.BulQuery(h => h.HaliAdi == haliAdi).FirstOrDefault();
                if (varMiHali != null)
                {
                    return "Halı Kayıtlı!";
                }
                Halilar halilar = new Halilar();
                halilar.KategoriID = kategoriID;
                halilar.MarkaID = markaID;
                halilar.RenkID = renkID;
                halilar.DesenID = desenID;
                halilar.BoyutID = boyutID;
                halilar.BarkodNo = barkodNo;
                halilar.HaliAdi = haliAdi;
                halilar.Fiyat = fiyat;
                halilar.Aciklama = aciklama;
                halilar.UretimTarihi = uretimTarihi;
                halilar.AktifMi = aktifMi;

                int sonuc = repository.Kaydet(halilar);
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

        public string Sil(int halilarID)
        {
            try
            {
                var pasifHali = repository.BulQuery(h => h.ID == halilarID).FirstOrDefault();
                if (pasifHali == null)
                {
                    return "Halı Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifHali.AktifMi == false)
                {
                    return "Halı Pasif Durumda";
                }

                pasifHali.AktifMi = false;
                int sonuc = repository.Guncelle(pasifHali);
                if (sonuc > 0)
                {
                    return "Halı Pasif İşlemi Başarılı";
                }
                return "Halı Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
