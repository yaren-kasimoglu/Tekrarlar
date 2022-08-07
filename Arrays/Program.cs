using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*

                1- Dizi tanımlarken sizinin boyutunun kesinlikle belli olması gerekiyor.
                2- Dizinin tipinin belli olması gerekiyor

            eleman sayısı-1 son indexin numarasını verir.
             */

            //Dizi Tanımlama şekilleri
            //int[] sayilar = new int[3];
            //string[] sehirler = new string[3] { "Ankara", "İstanbul", "İzmir" };
            //string[] sehirler2 = new string[] { "Ankara", "İstanbul", "İzmir" };
            //string[] sehirler3 = { "Ankara", "İstanbul", "İzmir" };



            #region ÖrnekVizeFinalOrtalama

            //double[,] notlar = new double[3, 3];
            
            ////Not=> Çok boyutlu 

            //int notlar_length=notlar.GetLength(0);

            //for (int i = 0; i < notlar_length; i++)
            //{
            //    Console.WriteLine($"{i+1}. öğrencinin vize notunu giriniz:");
            //    notlar[i,0] = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine($"{i+1}. öğrencinin lütfen final notunu giriniz: ");
            //    notlar[i, 1] = Convert.ToInt32(Console.ReadLine());

            //    notlar[i, 2] = ((notlar[i, 0]*0.30) +( notlar[i, 1]*0.70));

            //}

            //for (int i = 0; i < notlar_length; i++)
            //{
            //    Console.WriteLine($"{i+1}. öğrencinin vize notu : { notlar[i, 0]}, final notu : {notlar[i, 1]}, ortalaması : { notlar[i, 2]}");
            //}
            #endregion


            Console.ReadKey();

        }
    }
}
