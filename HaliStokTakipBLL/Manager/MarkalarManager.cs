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
    public class MarkalarManager : IMarka
    {
        HaliStokTakipDBEntities db;
        Repository<Markalar> repository;
        public MarkalarManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<Markalar>(db);
        }
        public Markalar Bul(string markaAdi)
        {
            throw new NotImplementedException();

        }

        public string Guncelle(int markalarID, string markaAdi, bool aktifMi, string aciklama)
        {
            try
            {
                var guncellenecekMarka = repository.BulQuery(m => m.ID == markalarID).FirstOrDefault();
                if (guncellenecekMarka == null)
                {
                    return "Marka Bulunamadı!";
                }
                guncellenecekMarka.MarkaAdi = markaAdi;
                guncellenecekMarka.AktifMi = aktifMi;
                guncellenecekMarka.Aciklama = aciklama;

                int sonuc = repository.Guncelle(guncellenecekMarka);

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

        public string Kaydet(string markaAdi, bool aktifMi, string aciklama)
        {
            try
            {
                var varMiMarka = repository.BulQuery(m => m.MarkaAdi == markaAdi).FirstOrDefault();
                if (varMiMarka != null)
                {
                    return "Marka Kayıtlı!";
                }
                Markalar markalar = new Markalar();
                markalar.MarkaAdi = markaAdi;
                markalar.AktifMi = aktifMi;
                markalar.Aciklama = aciklama;

                int sonuc = repository.Kaydet(markalar);
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

        public IEnumerable<Markalar> MarkalariListele()
        {
            return repository.Listele();
        }

        public string Sil(int markalarID)
        {
            try
            {
                var pasifMarka = repository.BulQuery(m => m.ID == markalarID).FirstOrDefault();
                if (pasifMarka == null)
                {
                    return "Marka Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifMarka.AktifMi == false)
                {
                    return "Marka Pasif Durumda";
                }

                pasifMarka.AktifMi = false;
                int sonuc = repository.Guncelle(pasifMarka);
                if (sonuc > 0)
                {
                    return "Marka Pasif İşlemi Başarılı";
                }
                return "Marka Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
