using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recusive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Faktoriyel(6));

            Console.ReadKey();
        }

        public static int Faktoriyel(int sayi)
        {

            if (sayi == 0 || sayi == 1)
            {
                return 1;
            }
            return sayi * Faktoriyel(sayi - 1);
        }
        
    }
}
