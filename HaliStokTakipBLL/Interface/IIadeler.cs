using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    public interface IIadeler
    {
        string Kaydet(int siparisID, DateTime iadeTarihi, string iadeNedeni, bool iadeDurumu);
        string Guncelle(int iadelerID, int siparisID, DateTime iadeTarihi, string iadeNedeni, bool iadeDurumu);
        string Sil(int iadelerID);
        IEnumerable<sp_IadeListesi_Result> IadeleriListele();
        Iadeler Bul(int siparisID,DateTime iadeTarihi);
    }
}
