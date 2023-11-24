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
    public class YetkilerManager : IYetki
    {
        HaliStokTakipDBEntities db;
        Repository<Yetkiler> repository;
        public YetkilerManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<Yetkiler>(db);
        }

        public Yetkiler Bul(string yetkiAdi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int yetkilerID, string yetkiAdi, bool aktifMi, string aciklama)
        {
            try
            {
                var guncellenecekYetki = repository.BulQuery(y => y.ID == yetkilerID).FirstOrDefault();
                if (guncellenecekYetki == null)
                {
                    return "Yetki Bulunamadı!";
                }
                guncellenecekYetki.YetkiAdi = yetkiAdi;
                guncellenecekYetki.AktifMi = aktifMi;
                guncellenecekYetki.Aciklama = aciklama;

                int sonuc = repository.Guncelle(guncellenecekYetki);

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

        public string Kaydet(string yetkiAdi, bool aktifMi, string aciklama)
        {
            try
            {
                var varMiYetki = repository.BulQuery(y => y.YetkiAdi == yetkiAdi).FirstOrDefault();
                if (varMiYetki != null)
                {
                    return "Yetki Kayıtlı!";
                }
                Yetkiler yetkiler = new Yetkiler();
                yetkiler.YetkiAdi = yetkiAdi;
                yetkiler.AktifMi = aktifMi;
                yetkiler.Aciklama = aciklama;

                int sonuc = repository.Kaydet(yetkiler);
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

        public IEnumerable<Yetkiler> YetkileriListele()
        {
            return repository.Listele();
        }

        public string Sil(int yetkilerID)
        {
            try
            {
                var pasifYetki = repository.BulQuery(y => y.ID == yetkilerID).FirstOrDefault();
                if (pasifYetki == null)
                {
                    return "Yetki Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifYetki.AktifMi == false)
                {
                    return "Yetki Pasif Durumda";
                }

                pasifYetki.AktifMi = false;
                int sonuc = repository.Guncelle(pasifYetki);
                if (sonuc > 0)
                {
                    return "Yetki Pasif İşlemi Başarılı";
                }
                return "Yetki Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
