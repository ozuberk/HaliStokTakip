using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    public interface IStok
    {
        string Kaydet(string stokAdi, int haliID, bool aktifMi, int stokMiktari, string aciklama);
        string Guncelle(int stoklarID, string stokAdi, int haliID, bool aktifMi, int stokMiktari, string aciklama);
        string Sil(int stoklarID);
        IEnumerable<sp_StokListesi_Result> StoklariListele();
        Stoklar Bul(string stokAdi);
    }
}
