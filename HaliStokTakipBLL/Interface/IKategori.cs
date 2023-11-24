using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    internal interface IKategori
    {
        string Kaydet(string kategoriAdi, bool aktifMi, string aciklama);
        string Guncelle(int kategorilerID, string kategoriAdi, bool aktifMi, string aciklama);
        string Sil(int kategorilerID);
        IEnumerable<Kategoriler> KategoriListele();
        Kategoriler Bul(string kategoriAdi);
    }
}
