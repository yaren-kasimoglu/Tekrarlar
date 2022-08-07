using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    public class Program
    {
        static void Main(string[] args)
        {


        tekrarGiris: Console.WriteLine("Lütfen ay bilgisini giriniz:");
            string ay = Console.ReadLine();
            string sonuc = "";


            switch (ay)
            {
                case "Aralık":
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
        }
    }
}
