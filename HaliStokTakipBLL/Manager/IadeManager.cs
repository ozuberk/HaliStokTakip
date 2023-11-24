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
    public class IadeManager : IIadeler
    {
        HaliStokTakipDBEntities db;
        Repository<Iadeler> repository;
        public IadeManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<Iadeler>(db);
        }
        public Iadeler Bul(int siparisID, DateTime iadeTarihi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int iadelerID, int siparisID, DateTime iadeTarihi, string iadeNedeni, bool iadeDurumu)
        {
            try
            {
                var guncellenecekIade = repository.BulQuery(i => i.ID == iadelerID).FirstOrDefault();
                if (guncellenecekIade == null)
                {
                    return "İade Bulunamadı!";
                }
                guncellenecekIade.SiparisID = siparisID;
                guncellenecekIade.IadeTarihi = iadeTarihi;
                guncellenecekIade.IadeNedeni = iadeNedeni;
                guncellenecekIade.IadeOnayDurumu = iadeDurumu;

                int sonuc = repository.Guncelle(guncellenecekIade);

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

        public string Kaydet(int siparisID, DateTime iadeTarihi, string iadeNedeni, bool iadeDurumu)
        {
            try
            {
                var varMiIade = repository.BulQuery(i => i.SiparisID == siparisID&&i.IadeTarihi==iadeTarihi).FirstOrDefault();
                if (varMiIade != null)
                {
                    return "İade Kayıtlı!";
                }
                Iadeler iadeler = new Iadeler();
                iadeler.SiparisID = siparisID;
                iadeler.IadeTarihi = iadeTarihi;
                iadeler.IadeNedeni = iadeNedeni;
                iadeler.IadeOnayDurumu = iadeDurumu;

                int sonuc = repository.Kaydet(iadeler);
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

        public IEnumerable<sp_IadeListesi_Result> IadeleriListele()
        {
            return db.sp_IadeListesi().ToList();
        }

        public string Sil(int iadelerID)
        {
            try
            {
                var pasifIade = repository.BulQuery(i => i.ID == iadelerID).FirstOrDefault();
                if (pasifIade == null)
                {
                    return "İade Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifIade.IadeOnayDurumu == false)
                {
                    return "İade Pasif Durumda";
                }

                pasifIade.IadeOnayDurumu = false;
                int sonuc = repository.Guncelle(pasifIade);
                if (sonuc > 0)
                {
                    return "İade Pasif İşlemi Başarılı";
                }
                return "İade Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
