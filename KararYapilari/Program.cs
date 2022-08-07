using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    public class Program
    {
        static void Main(string[] args)
        {
        #region Örnek1
        //Console.WriteLine("1. sayiyi giriniz: ");
        //int sayi1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("2. sayiyi giriniz: ");
        //int sayi2 = Convert.ToInt32(Console.ReadLine());

        //if (sayi1 > sayi2)
        //{
        //    Console.WriteLine("1. sayi büyüktür");
        //}
        //else if (sayi2 > sayi1)
        //{
        //    Console.WriteLine("2. sayi büyük");
        //}
        //else
        //{
        //    Console.WriteLine("sayılar eşittir");
        //}
        #endregion


        #region Örnek2
        //Console.WriteLine("1. sayiyi giriniz: ");
        //int sayi1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("2. sayiyi giriniz: ");
        //int sayi2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("3. sayiyi giriniz: ");
        //int sayi3 = Convert.ToInt32(Console.ReadLine());

        //if (sayi1 > sayi2 && sayi1 > sayi3)
        //{
        //    Console.WriteLine("1. sayi büyüktür");
        //}
        //else if (sayi2 > sayi1 && sayi2 > sayi3)
        //{
        //    Console.WriteLine("2. sayi büyük");
        //}
        //else if (sayi3 > sayi1 && sayi3 > sayi2)
        //{
        //    Console.WriteLine("2. sayi büyük");
        //}
        //else
        //{
        //    Console.WriteLine("sayılar eşittir");
        //}
        #endregion

        #region Örnek3

        // Console.WriteLine("1. sayiyi giriniz: ");
        // int sayi = Convert.ToInt32(Console.ReadLine());

        //if (sayi%2==0)
        //{
        //    Console.WriteLine("Sayı çifttir");
        //}
        //else
        //{
        //    Console.WriteLine("Sayı tektir");
        //}

        #endregion

        #region Örnek4

        //Console.WriteLine("1. sayiyi giriniz: ");
        //int sayi = Convert.ToInt32(Console.ReadLine());
        //int sonuc = 0;
        //if (sayi % 2 == 0)
        //{
        //    sonuc = sayi / 2;

        //    Console.WriteLine("sonuc: " + sonuc);
        //}
        //else
        //{
        //    sonuc = sayi * 2;
        //    Console.WriteLine("sonuc: " + sonuc);
        //}


        #endregion

        #region TurnaryExample

        // //turnaryif = daha kısa bir if kullanma

        // int ekrandnaGirilenSayi = 150;
        // int toplam = 0;

        // if (ekrandnaGirilenSayi>100)
        // {
        //     toplam += ekrandnaGirilenSayi;
        // }
        // else
        // {
        //     toplam -= ekrandnaGirilenSayi;
        // }

        ////yukardaki ifadenin turnary if hali aşağıdakidir

        // toplam = ekrandnaGirilenSayi > 100 ? toplam + ekrandnaGirilenSayi : toplam - ekrandnaGirilenSayi;



        #endregion


        #region KararyapilaiÖrnek

        tekrarGiris: Console.WriteLine("Lütfen ay bilgisini giriniz:");
            string ay = Console.ReadLine();
            string sonuc = "";


            switch (ay)
            {
                case "Aralik":
                case "Ocak":
                case "Subat":
                    {
                        sonuc = "Kış mevsimi";
                        break;
                    }

                case "Mart":
                case "Nisan":
                case "Mayis":
                    {
                        sonuc = "İlkbahar mevsimi";
                        break;
                    }

                case "Haziran":
                case "Temmuz":
                case "Agustos":
                    {
                        sonuc = "Yaz mevsimi";
                        break;
                    }

                case "Eylul":
                case "Ekim":
                case "Kasim":
                    {
                        sonuc = "Sonbahar mevsimi";
                        break;
                    }

                default: { sonuc = "Ay bilgisi anlaşılamadı"; break; }
            }

            Console.WriteLine("sonuc: " + sonuc);

            Console.WriteLine("Yeni bir ay bilgisi girmek ister misiniz? ");
            string giris = Console.ReadLine();

            if (giris == "E" || giris == "e")
            {
                Console.Clear();
                goto tekrarGiris;
            }
            else
            {
                Console.WriteLine("Uygulama Sonlanıyor......");
                Environment.Exit(0); //console uygulamasını sonlandırmak için kullanılır
            }

            #endregion


            #region Örnek5

            // string isim = "admin";
            // string sifre = "123";

            //tekrarSor: Console.WriteLine("adınızı giriniz. ");
            // string ad = Console.ReadLine();
            // Console.WriteLine("sifreniz.: ");
            // string pass = Console.ReadLine();

            // if (ad==isim && pass==sifre)
            // {
            //     Console.WriteLine("bilgiler doğrudur"); 

            // }
            // else
            // {
            //     goto tekrarSor;
            // }

            #endregion


            Console.ReadKey();

        }
    }
}
