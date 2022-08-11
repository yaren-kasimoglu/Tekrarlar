using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Ogrenci
    {
        public Ogrenci(int Id,int No)
        {
            this.id= Id;
            this.no= No;
        }


        public int id { get; set; }
        public int no { get; set; }
    }
}
