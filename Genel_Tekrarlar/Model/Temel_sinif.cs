using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genel_Tekrarlar.Model
{
    public class Temel_sinif
    {

        public int sayiTuret(int x , int y)
        {
            int sonuc = 0;
            Random rnd=new Random();
            sonuc = rnd.Next(x, y);

            return sonuc;
        }
    }
}
