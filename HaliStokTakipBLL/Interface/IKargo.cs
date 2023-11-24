using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    public interface IKargo
    {
        string Kaydet(int siparisID,string firmaAdi,string takipKodu,DateTime tahminiTeslim,DateTime teslimTarihi, bool aktifMi, string aciklama);
        string Guncelle(int kargolarID, int siparisID, string firmaAdi, string takipKodu, DateTime tahminiTeslim, DateTime teslimTarihi, bool aktifMi, string aciklama);
        string Sil(int kargolarID);
        IEnumerable<sp_KargoListesi_Result> KargolariListele();
        KargoTakip Bul(string takipKodu);
    }
}
