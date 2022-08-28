using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genel_Tekrarlar.Model
{
    public class Faktoriyel
    {
        int sayi, sonuc, i;



        public int Deger
        {
            get
            {
                sonuc = 1;
                for ( i = 1; i <= sayi; i++)
                {
                    sonuc = i * sonuc;
                }

                return sonuc;

            }



            set { sayi = value; }
        }


    }
}
