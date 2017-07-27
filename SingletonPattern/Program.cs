using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DBHelper helper1 = DBHelper.CreateDbHelper("con 1");
            helper1.StateMessage = "deneme";

            DBHelper helper2 = DBHelper.CreateDbHelper("con 2");

            Console.WriteLine(helper2.StateMessage);
            Console.ReadKey();
        }
    }
}
