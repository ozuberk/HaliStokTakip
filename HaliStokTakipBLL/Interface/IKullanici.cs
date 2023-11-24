using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    internal interface IKullanici
    {
        string Kaydet(string kullaniciAdi, string kullaniciSifre, string email, int yetkiID, string aciklama, bool aktifMi);
        string Guncelle(int kullaniciID, string kullaniciAdi, string kullaniciSifre, string email, int yetkiID, string aciklama, bool aktifMi);
        string Sil(int kullaniciID);
        IEnumerable<sp_KullaniciListesi_Result> KullaniciListele();
        Kullanicilar Bul(string kullaniciAdi);
        Kullanicilar Giris(string kullaniciAdi, string sifre);

        int Yetki(string kullaniciAdi, string sifre);
    }
}
