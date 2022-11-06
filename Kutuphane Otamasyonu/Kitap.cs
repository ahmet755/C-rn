using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Otamasyonu
{
    internal class Kitap
    {
        public uint UID;
        public string KitapAd;
        public string Yazar;
        public string Tur;
        public string YayinEvi;
        public string BasimYili;
        public Uye Sahip;

        public void Kirala (Uye t_uye)
        {
            Sahip = t_uye;
        }
    }

}
