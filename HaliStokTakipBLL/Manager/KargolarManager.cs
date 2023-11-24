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
    public class KargolarManager : IKargo
    {
        HaliStokTakipDBEntities db;
        Repository<KargoTakip> repository;
        public KargolarManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<KargoTakip>(db);
        }

        public KargoTakip Bul(string takipKodu)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int kargolarID, int siparisID, string firmaAdi, string takipKodu, DateTime tahminiTeslim, DateTime teslimTarihi, bool aktifMi, string aciklama)
        {
            try
            {
                var guncellenecekKargo = repository.BulQuery(k => k.ID == kargolarID).FirstOrDefault();
                if (guncellenecekKargo == null)
                {
                    return "Kargo Bulunamadı!";
                }
                guncellenecekKargo.SiparisID = siparisID;
                guncellenecekKargo.FirmaAdi = firmaAdi;
                guncellenecekKargo.TakipKodu = takipKodu;
                guncellenecekKargo.TahminiTeslimTarihi = tahminiTeslim;
                guncellenecekKargo.TeslimTarihi= teslimTarihi;
                guncellenecekKargo.AktifMi = aktifMi;
                guncellenecekKargo.Aciklama = aciklama;

                int sonuc = repository.Guncelle(guncellenecekKargo);

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

        public IEnumerable<sp_KargoListesi_Result> KargolariListele()
        {
            return db.sp_KargoListesi().ToList();
        }

        public string Kaydet(int siparisID, string firmaAdi, string takipKodu, DateTime tahminiTeslim, DateTime teslimTarihi, bool aktifMi, string aciklama)
        {
            try
            {
                var varMiKargo = repository.BulQuery(k => k.TakipKodu == takipKodu).FirstOrDefault();
                if (varMiKargo != null)
                {
                    return "Kargo Kayıtlı!";
                }
                KargoTakip kargolar = new KargoTakip();
                kargolar.SiparisID = siparisID;
                kargolar.FirmaAdi = firmaAdi;
                kargolar.TakipKodu = takipKodu;
                kargolar.TahminiTeslimTarihi = tahminiTeslim;
                kargolar.TeslimTarihi = teslimTarihi;
                kargolar.AktifMi = aktifMi;
                kargolar.Aciklama = aciklama;

                int sonuc = repository.Kaydet(kargolar);
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

        public string Sil(int kargolarID)
        {
            try
            {
                var pasifKargo = repository.BulQuery(r => r.ID == kargolarID).FirstOrDefault();
                if (pasifKargo == null)
                {
                    return "Kargo Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifKargo.AktifMi == false)
                {
                    return "Kargo Pasif Durumda";
                }

                pasifKargo.AktifMi = false;
                int sonuc = repository.Guncelle(pasifKargo);
                if (sonuc > 0)
                {
                    return "Kargo Pasif İşlemi Başarılı";
                }
                return "Kargo Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
