using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLoopExamples
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Örnek1

            //kullanıcıdan her defasında bir sayı alıp tekrar girmek ister misiniz diye soru soran ve eğer girmek istemez ise sayıların toplamını ekrana ayzdıran program


            //int[] sayilar = new int[0];

            //char keyChar = Console.ReadKey().KeyChar;

            //do
            //{

            //    Console.WriteLine("\nbir sayı giriniz: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    Array.Resize(ref sayilar, sayilar.Length + 1);
            //    sayilar[sayilar.Length - 1] = sayi;


            //    Console.WriteLine("\nTekrar bir sayi girmek istiyor musunuz? \n");
            //    keyChar = Console.ReadKey().KeyChar;



            //} while (keyChar != 'N');

            //int toplam = 0;

            //foreach (int sayi in sayilar)
            //{
            //    toplam = toplam + sayi;
            //}

            //Console.WriteLine($"\n{sayilar.Length} tane sayı girişi yapıldı toplamı:" + toplam);

            #endregion



            Console.ReadKey();
        }
    }
}
