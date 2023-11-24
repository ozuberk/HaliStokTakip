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
    public class BoyutlarManager : IBoyutlar
    {
        HaliStokTakipDBEntities db;
        Repository<Boyutlar> repository;
        public BoyutlarManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<Boyutlar>(db);
        }
        public IEnumerable<Boyutlar> BoyutlariListele()
        {
            return repository.Listele();
        }

        public Boyutlar Bul(string boyutAdi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int boyutlarID, string boyutAdi, int eni, int boyu,int alani, bool aktifMi)
        {
            try
            {
                var guncellenecekBoyut = repository.BulQuery(b => b.ID == boyutlarID).FirstOrDefault();
                if (guncellenecekBoyut == null)
                {
                    return "Boyut Bulunamadı!";
                }
                guncellenecekBoyut.BoyutAdi = boyutAdi;
                guncellenecekBoyut.Eni = eni;
                guncellenecekBoyut.Boyu = boyu;
                guncellenecekBoyut.Alani = eni * boyu;
                guncellenecekBoyut.AktifMi= aktifMi;

                int sonuc = repository.Guncelle(guncellenecekBoyut);

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

        public string Kaydet(string boyutAdi, int eni, int boyu,int alani, bool aktifMi)
        {
            try
            {
                var varMiBoyut = repository.BulQuery(b => b.BoyutAdi == boyutAdi).FirstOrDefault();
                if (varMiBoyut != null)
                {
                    return "Boyut Kayıtlı!";
                }
                Boyutlar boyutlar = new Boyutlar();
                boyutlar.BoyutAdi = boyutAdi;
                boyutlar.Eni= eni;
                boyutlar.Boyu= boyu;
                boyutlar.Alani = eni * boyu;
                boyutlar.AktifMi = aktifMi;

                int sonuc = repository.Kaydet(boyutlar);
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

        public string Sil(int boyutlarID)
        {
            try
            {
                var pasifBoyut = repository.BulQuery(b => b.ID == boyutlarID).FirstOrDefault();
                if (pasifBoyut == null)
                {
                    return "Boyut Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifBoyut.AktifMi == false)
                {
                    return "Boyut Pasif Durumda";
                }

                pasifBoyut.AktifMi = false;
                int sonuc = repository.Guncelle(pasifBoyut);
                if (sonuc > 0)
                {
                    return "Boyut Pasif İşlemi Başarılı";
                }
                return "Boyut Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
