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
    public class DesenManager : IDesenler
    {
        HaliStokTakipDBEntities db;
        Repository<Desenler> repository;
        public DesenManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<Desenler>(db);
        }
        public Desenler Bul(string desenAdi)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Desenler> DesenleriListele()
        {
            return repository.Listele();
        }

        public string Guncelle(int desenlerID, string desenAdi, bool aktifMi, string aciklama)
        {
            try
            {
                var guncellenecekDesen = repository.BulQuery(d => d.ID == desenlerID).FirstOrDefault();
                if (guncellenecekDesen == null)
                {
                    return "Desen Bulunamadı!";
                }
                guncellenecekDesen.DesenAdi = desenAdi;
                guncellenecekDesen.AktifMi = aktifMi;
                guncellenecekDesen.Aciklama = aciklama;

                int sonuc = repository.Guncelle(guncellenecekDesen);

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

        public string Kaydet(string desenAdi, bool aktifMi, string aciklama)
        {
            try
            {
                var varMiDesen = repository.BulQuery(d => d.DesenAdi == desenAdi).FirstOrDefault();
                if (varMiDesen != null)
                {
                    return "Desen Kayıtlı!";
                }
                Desenler desenler = new Desenler();
                desenler.DesenAdi = desenAdi;
                desenler.AktifMi = aktifMi;
                desenler.Aciklama = aciklama;

                int sonuc = repository.Kaydet(desenler);
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

        public string Sil(int desenlerID)
        {
            try
            {
                var pasifDesen = repository.BulQuery(d => d.ID == desenlerID).FirstOrDefault();
                if (pasifDesen == null)
                {
                    return "Desen Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifDesen.AktifMi == false)
                {
                    return "Desen Pasif Durumda";
                }

                pasifDesen.AktifMi = false;
                int sonuc = repository.Guncelle(pasifDesen);
                if (sonuc > 0)
                {
                    return "Desen Pasif İşlemi Başarılı";
                }
                return "Desen Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
