using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    internal interface IRenkler
    {
        string Kaydet(string renkAdi, bool aktifMi, string aciklama);
        string Guncelle(int renklerID, string renkAdi, bool aktifMi, string aciklama);
        string Sil(int renklerID);
        IEnumerable<Renkler> RenkleriListele();
        Renkler Bul(string renkAdi);
    }
}
