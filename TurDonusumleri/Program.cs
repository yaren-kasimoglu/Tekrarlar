using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Tür Dönüşümleri

         

            //Tip Dönüşümleri
            //Conversion


            /*
             Convert sınıfı
            Parse Metodu
            ve Casting işlemi kullanılıor
            ToString metodu ile de tip dönüştürme yapılabilir. 
             
             */


            /*
             Convert Sınıfı
             
             */

            string sayi = "1000";
            int int_sayi=Convert.ToInt32(sayi); // sadece int e değer diğer tiplere ve tipler arasında da dönüşüm yapılabilir.

            /*
             
             Parse Metodu: Dönüştürülmek istenen tip üzerinden primitive typelarda kullanılır.
            
            Parse metotları sadece string üzerinden dönüşüm yapar 
             */

            string parse_sayi = "1500";
            int int_Sayi1=int.Parse(parse_sayi);
            double double_sayi = double.Parse(parse_sayi);



            /*Cast : ricada bulubnma
             bunu buna dönüştürmeyi dene? bu değermiş gibi kabuyl et ??
             
             */

            int sayi2 = 1000;
            byte donusturulenSayi = (byte)sayi2;

            Console.WriteLine(sayi2);



            //BÜTÜN TİPLERİN ATASI OBJECTTİR

            //implicit convert: kapalı tip  dönüşümü
            
            //atanmak istenen değer atanan taraftaki değer aralığı içinde ise kapalı tip dönüşümü yapılır


            int x = 150;
            long y = x;

            //explicit convert: açık tip dönüşümü

            //atanmak istenen değer atanan taraftaki değer aralığı içinde ama tiplerin değer aralığı uyymuyoır ise cast işlemi yapılarak  açık bir şekilde dönüştütülmesi gerekiyor                                     

            long z = 1000;
            int r = (int)z;

            //range aralığınma göçre değerlendiriyor. aslında cast işlemi yapıyoruz

            //explicit ve cast işlemi aynıdır.

            //Convert
            //Parse
            //Cast
            //İmplicit
            //Explicit
            //Boxing=> kutulama
            //Unboxing=> kutudan çıkarma



            int sayi4 = 150;
            object object_sayi = sayi; //sayıyı object e atama işlemi BOXING
            int sayi5 = (int)object_sayi; //UNBOXING





            #endregion


            Console.ReadKey();
        }
    }
}
