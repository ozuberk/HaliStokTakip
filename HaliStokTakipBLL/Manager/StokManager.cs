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
    public class StokManager:IStok
    {
        HaliStokTakipDBEntities db;
        Repository<Stoklar> repository;
        public StokManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<Stoklar>(db);
        }

        public Stoklar Bul(string stokAdi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int stoklarID, string stokAdi, int haliID, bool aktifMi, int stokMiktari, string aciklama)
        {
            try
            {
                var guncellenecekStok = repository.BulQuery(s => s.ID == stoklarID).FirstOrDefault();
                if (guncellenecekStok == null)
                {
                    return "Stok Bulunamadı!";
                }
                guncellenecekStok.StokAdi = stokAdi;
                guncellenecekStok.HaliID = haliID;
                guncellenecekStok.AktifMi = aktifMi;
                guncellenecekStok.StokMiktari = stokMiktari;
                guncellenecekStok.Aciklama = aciklama;

                int sonuc = repository.Guncelle(guncellenecekStok);

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

        public string Kaydet(string stokAdi, int haliID, bool aktifMi, int stokMiktari, string aciklama)
        {
            try
            {
                var varMiStok = repository.BulQuery(s => s.StokAdi == stokAdi).FirstOrDefault();
                if (varMiStok != null)
                {
                    return "Stok Kayıtlı!";
                }
                Stoklar stoklar = new Stoklar();
                stoklar.StokAdi = stokAdi;
                stoklar.HaliID = haliID;
                stoklar.AktifMi = aktifMi;
                stoklar.StokMiktari = stokMiktari;
                stoklar.Aciklama = aciklama;

                int sonuc = repository.Kaydet(stoklar);
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

        public IEnumerable<sp_StokListesi_Result> StoklariListele()
        {
            return db.sp_StokListesi().ToList();
        }

        public string Sil(int stoklarID)
        {
            try
            {
                var pasifStok = repository.BulQuery(s => s.ID == stoklarID).FirstOrDefault();
                if (pasifStok == null)
                {
                    return "Stok Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifStok.AktifMi == false)
                {
                    return "Stok Pasif Durumda";
                }

                pasifStok.AktifMi = false;
                int sonuc = repository.Guncelle(pasifStok);
                if (sonuc > 0)
                {
                    return "Stok Pasif İşlemi Başarılı";
                }
                return "Stok Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
