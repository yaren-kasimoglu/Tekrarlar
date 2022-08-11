using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseOrnek_withRandom
{
    public class Program
    {
        static void Main(string[] args)
        {
            char keyChar = Console.ReadKey().KeyChar;

            do
            {
                Random rnd = new Random();
                int ay = rnd.Next(1, 13);
              

                switch (ay)
                {

                    case 12:
                    case 1:
                    case 2:
                        {
                            Console.WriteLine("\n" + ay);
                            Console.WriteLine("Girilen Ay Kış Mevsimindedir");
                            break;
                        }
                    case 3:
                    case 4:
                    case 5:
                        {
                            Console.WriteLine("\n" + ay);
                            Console.WriteLine("Girilen Ay İlk Bahar Mevsimindedir");
                            break;
                        }
                    case 6:
                    case 7:
                    case 8:
                        {
                            Console.WriteLine("\n" + ay);
                            Console.WriteLine("Girilen Ay Yaz Mevsimindedir");
                            break;
                        }
                    case 9:
                    case 10:
                    case 11:
                        {
                            Console.WriteLine("\n" + ay);
                            Console.WriteLine("Girilen Ay Son Bahar Mevsimindedir");
                            break;
                        }

                }

                

                Console.WriteLine("Yeni bir sayı üretmek ister misiniz: ");

                keyChar = Console.ReadKey().KeyChar;

            } while (keyChar == 'R');



            Console.ReadKey();
         

        }
    }
}
