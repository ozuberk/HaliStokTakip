using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    internal interface IMusteri
    {
        string Kaydet(string adi, string adresi, string telefon, string email, string vergiNo, string aciklama, bool aktifMi);
        string Guncelle(int musterilerID, string adi, string adresi, string telefon, string email, string vergiNo, string aciklama, bool aktifMi);
        string Sil(int musterilerID);
        IEnumerable<Musteriler> MusteriListele();
        Musteriler Bul(string adi);
    }
}
