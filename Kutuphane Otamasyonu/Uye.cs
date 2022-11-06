using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Otamasyonu
{
    internal class Uye
    {
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public List<Kitap> AldigiKitapList;
        public List<Kitap> EskiAldigiKitapList;

        public void Kirala(Kitap t_kitap)
        {
            AldigiKitapList.Add(t_kitap);
        }
        public void KiralalikSonlandır(Kitap t_kitap)
        {
            AldigiKitapList.Remove(t_kitap);
            EskiAldigiKitapList.Add(t_kitap);
        }
    }

}
