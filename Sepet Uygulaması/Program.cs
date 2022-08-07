using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepet_Uygulaması
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ürün ekleme
            //ürün listeleme
            //ürün seçme
            //sepete ekleme
            //sipariş tamamlama

            string[] products = new string[0]; //ürün isimlerini tutmak için kullanılacak dizi
            decimal[] productPrices = new decimal[0]; // ürün fiyatları için kullanılacak dizi
            int[] basket = new int[0]; // sepet için kullanılacak dizi

        Main:
            do
            {
                Console.Clear();
                Console.WriteLine("ALDI ALIYOR....");
                Console.WriteLine(" 1-Yeni Ürün Ekleme\n 2-Ürün Listeleme\n 3-Ürün Seçme ve Sepete Ekleme\n 4-Satın Alma");

                Console.WriteLine("Lütfen seçim yapın: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        {
                            goto productAdd;
                            break;
                        }
                    case 2:
                        {
                            goto productList;
                            break;
                        }
                    case 3:
                        {
                            goto addToBasket;
                            break;
                        }                    
                  

                }


            } while (true);


        productAdd:

            ConsoleKey productAddKey;

            do
            {

                Console.Clear();
                Console.WriteLine(" lütfen ürün adı girişi yapınız: ");
                string productName = Console.ReadLine();

                Console.WriteLine(" Lütfen ürün fiyatını giriniz: ");
                decimal productPrice = Convert.ToDecimal(Console.ReadLine());

                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = productName;

                Array.Resize(ref productPrices, productPrices.Length + 1);
                productPrices[productPrices.Length - 1] = productPrice;

                Console.WriteLine("Başka ürün eklemek ister misiniz? ");
                productAddKey = Console.ReadKey().Key;

            } while (productAddKey != ConsoleKey.N);
            goto Main;


        productList:

            Console.Clear();
            for (int i = 0; i < products.Length; i++)
            {
                string productListName = products[i];
                decimal productListPrice = productPrices[i];

                Console.WriteLine($"{i + 1} {productListName} --- {(productListPrice)}");
            }

            Console.ReadKey();

            goto Main;

        addToBasket:

            do
            {
                Console.Clear();


                Console.WriteLine("---------------SEPET---------------");
                decimal baskettotal = 0;
                for (int i = 0; i < basket.Length; i++)
                {
                    int secilenUrunIndeks = basket[i];
                    string name = products[secilenUrunIndeks];
                    decimal price = productPrices[secilenUrunIndeks];
                    Console.WriteLine($"{i + 1} {name} {price}");
                    baskettotal += price;

                }
                Console.WriteLine($"Sepet toplamı : {baskettotal} \n");

                Console.WriteLine("***********Ürün Listesi***********");

                for (int i = 0; i < products.Length; i++)
                {
                    string producyAddName = products[i];
                    decimal productAddPrice = productPrices[i];

                    Console.WriteLine($"{i + 1} {producyAddName} --- {(productAddPrice)}");
                }

                Console.WriteLine("lütfen ürün seçimi yapınız: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim > 0 && secim <= products.Length)
                {
                    //seçim doğru ve sepete ekleme yap
                    Array.Resize(ref basket, basket.Length + 1);
                    basket[basket.Length - 1] = secim - 1; //kullanıcının seçtiği sayı indeks num bir fazlası olduğu için -1 byapıyoruz tam indexi versin diye
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Seçim anlaşılamadı lütfen bir tuşa basın ve tekrar seçim yapın");
                    Console.ReadKey();
                    goto addToBasket;
                }

                Console.WriteLine("Sepete başka ürün eklemek ister misiniz?");
                ConsoleKey questionProductResult = Console.ReadKey().Key;

                if (questionProductResult == ConsoleKey.N)
                {
                    goto Main;
                }

            } while (true);



        }
    }
}
