using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    internal interface ISiparis
    {
        string Kaydet(string siparisAdi, int musteriID, DateTime sipariTarihi, DateTime teslimatTarihi, bool siparisDurumu, decimal toplamTutar);
        string Guncelle(int siparislerID, string siparisAdi, int musteriID, DateTime sipariTarihi, DateTime teslimatTarihi, bool siparisDurumu, decimal toplamTutar);
        string Sil(int siparislerID);
        IEnumerable<sp_SiparisListesi_Result> SiparisleriListele();
        Siparisler Bul(string siparisAdi);
    }
}
