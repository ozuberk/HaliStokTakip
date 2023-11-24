using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    internal interface IDesenler
    {
        string Kaydet(string desenAdi, bool aktifMi, string aciklama);
        string Guncelle(int desenlerID, string desenAdi, bool aktifMi, string aciklama);
        string Sil(int desenlerID);
        IEnumerable<Desenler> DesenleriListele();
        Desenler Bul(string desenAdi);
    }
}
