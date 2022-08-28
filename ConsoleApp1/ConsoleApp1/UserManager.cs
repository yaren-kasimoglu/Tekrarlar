using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class UserManager
    {

    public void Add(Users user)
        {
            Console.WriteLine(user.Name + " eklendi");
        }

    public void Update(Users user)
        {
            Console.WriteLine(user.Name + " bilgileri güncellendi");

        }


    }
}
