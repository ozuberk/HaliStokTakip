using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    internal interface IHali
    {
        string Kaydet(int kategoriID,int markaID,int renkID,int desenID,int boyutID,string barkodNo,string haliAdi,decimal fiyat,string aciklama,DateTime uretimTarihi,bool aktifMi);
        string Guncelle(int halilarID, int kategoriID, int markaID, int renkID, int desenID, int boyutID, string barkodNo, string haliAdi, decimal fiyat, string aciklama, DateTime uretimTarihi, bool aktifMi);
        string Sil(int halilarID);
        IEnumerable<sp_HaliListesi_Result> HalilariListele();
        Halilar Bul(string haliAdi);
    }
}
