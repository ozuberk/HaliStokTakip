using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    internal interface IMarka
    {
        string Kaydet(string markaAdi, bool aktifMi, string aciklama);
        string Guncelle(int markalarID, string markaAdi, bool aktifMi, string aciklama);
        string Sil(int markalarID);
        IEnumerable<Markalar> MarkalariListele();
        Markalar Bul(string markaAdi);
    }
}
