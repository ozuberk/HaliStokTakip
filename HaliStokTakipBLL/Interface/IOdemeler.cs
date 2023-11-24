using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    public interface IOdemeler
    {
        string Kaydet(int siparisID, DateTime odemeTarihi, string odemeYontemi, bool aktifMi);
        string Guncelle(int odemeID,int siparisID, DateTime odemeTarihi, string odemeYontemi, bool aktifMi);
        string Sil(int odemeID);
        IEnumerable<sp_OdemeListesi_Result> OdemeleriListele();
        SiparisOdeme Bul(int odemeID);
    }
}
