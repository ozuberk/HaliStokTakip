using HaliStokTakipDLL;
using System.Collections.Generic;

namespace HaliStokTakipBLL.Interface
{
    internal interface IYetki
    {
        string Kaydet(string yetkiAdi, bool aktifMi, string aciklama);
        string Guncelle(int yetkilerID, string yetkiAdi, bool aktifMi, string aciklama);
        string Sil(int yetkilerID);
        IEnumerable<Yetkiler> YetkileriListele();
        Yetkiler Bul(string yetkiAdi);
    }
}
