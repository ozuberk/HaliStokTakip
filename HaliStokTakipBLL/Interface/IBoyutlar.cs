using HaliStokTakipDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliStokTakipBLL.Interface
{
    internal interface IBoyutlar
    {
        string Kaydet(string boyutAdi, int eni, int boyu,int alani, bool aktifMi);
        string Guncelle(int boyutlarID, string boyutAdi, int eni, int boyu,int alan, bool aktifMi);
        string Sil(int boyutlarID);
        IEnumerable<Boyutlar> BoyutlariListele();
        Boyutlar Bul(string boyutAdi);
    }
}
