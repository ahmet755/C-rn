using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Otamasyonu
{
    internal class Raf
    {
        public string Tur { get; set; }
        public List<Kitap> KitapList;

        public void KitapEkle(Kitap t_Kitap)
        {
            KitapList.Add(t_Kitap);
        }

        public void KitapCıkar(Kitap t_Kitap)
        {

        }
    }
}
