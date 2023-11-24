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
    public class KategoriManager : IKategori
    {
        HaliStokTakipDBEntities db;
        Repository<Kategoriler> repository;
        public KategoriManager()
        {
            db = new HaliStokTakipDBEntities();
            repository = new Repository<Kategoriler>(db);
        }
        public Kategoriler Bul(string kategoriAdi)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int kategorilerID, string kategoriAdi, bool aktifMi, string aciklama)
        {
            try
            {
                var guncellenecekKategori = repository.BulQuery(k => k.ID == kategorilerID).FirstOrDefault();
                if (guncellenecekKategori == null)
                {
                    return "Kategori Bulunamadı!";
                }
                guncellenecekKategori.KategoriAdi = kategoriAdi;
                guncellenecekKategori.AktifMi = aktifMi;
                guncellenecekKategori.Aciklama = aciklama;

                int sonuc = repository.Guncelle(guncellenecekKategori);

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

        public string Kaydet(string kategoriAdi, bool aktifMi, string aciklama)
        {
            try
            {
                var varMiRenk = repository.BulQuery(r => r.KategoriAdi == kategoriAdi).FirstOrDefault();
                if (varMiRenk != null)
                {
                    return "Kategori Kayıtlı!";
                }
                Kategoriler kategoriler = new Kategoriler();
                kategoriler.KategoriAdi = kategoriAdi;
                kategoriler.AktifMi = aktifMi;
                kategoriler.Aciklama = aciklama;

                int sonuc = repository.Kaydet(kategoriler);
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

        public IEnumerable<Kategoriler> KategoriListele()
        {
            return repository.Listele();
        }

        public string Sil(int kategorilerID)
        {
            try
            {
                var pasifKategori = repository.BulQuery(r => r.ID == kategorilerID).FirstOrDefault();
                if (pasifKategori == null)
                {
                    return "Kategori Bulunamadı, Yeniden Kontrol Ediniz.";
                }
                if (pasifKategori.AktifMi == false)
                {
                    return "Kategori Pasif Durumda";
                }

                pasifKategori.AktifMi = false;
                int sonuc = repository.Guncelle(pasifKategori);
                if (sonuc > 0)
                {
                    return "Kategori Pasif İşlemi Başarılı";
                }
                return "Kategori Pasif İşlemi Başarısız";
            }
            catch (Exception ex)
            {
                return "İşlem Esnasında Bir Hata oluştu \nHATA: " + ex.Message;
            }
        }
    }
}
