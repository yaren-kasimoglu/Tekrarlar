using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genel_Tekrarlar.Model
{
    public class Mirasci_Sinif:Temel_sinif
    {
        public object Turet()
        {
            int sayi = 0;
            sayi = sayiTuret(0, 100);
            return sayi;
        }
    }
}
