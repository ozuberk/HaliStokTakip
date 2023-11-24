using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    internal interface INotlar
    {
        string Kaydet(int kullaniciID, DateTime notTarihi, string notIcerigi, bool aktifMi);
        string Guncelle(int notlarID, int kullaniciID, DateTime notTarihi, string notIcerigi, bool aktifMi);
        string Sil(int notlarID);
        IEnumerable<sp_NotListesi_Result> NotlariListele();
        Notlar Bul(int kullaniciID, DateTime notTarihi);
    }
}
