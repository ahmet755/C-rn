using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Otamasyonu
{
    internal class KutupHane
    {
        public string KutuphaneIsmi { get; set; }
        public List<Raf> RafList;
        public List<Kitap> KitapList;
        public List<Uye> UyeList;

        public void UyeEkle(Uye t_uye)
        {
            UyeList.Add(t_uye);
        }

        public void UyeSil(Uye t_uye)
        {
            UyeList.Remove(t_uye);
        }

        public void RafEkle(Raf t_raf)
        {
            RafList.Add(t_raf);
        }
        public void UyeEkle(Uye t_uye)
        {
            UyeList.Add(t_uye);
        }
    }

}
