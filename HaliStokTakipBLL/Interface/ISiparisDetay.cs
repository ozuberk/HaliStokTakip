using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    internal interface ISiparisDetay
    {
        string Kaydet(int siparisID, int haliID, string aciklama, bool aktifMi);
        string Guncelle(int siparisID, int haliID, string aciklama, bool aktifMi);
        string Sil(int siparisID, int haliID);
        IEnumerable<SiparisDetay> SDetayListele();
        SiparisDetay Bul(int siparisID);
    }
}
