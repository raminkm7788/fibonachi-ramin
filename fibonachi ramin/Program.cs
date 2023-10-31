using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 1;
            int z;
            int i;
            int number;
            Console.WriteLine("enter number:");
            number = int.Parse(Console.ReadLine());
            Console.Write(x + "" +y + "");
            for (i = 2; i < number; i++)

            {
                z = x+ y;
                Console.Write(z + "");
                x = y;
                y = z;

            }
            Console.WriteLine("is");
            Console.ReadKey();
            Console.Clear();
           
        }
    }
}
//رامین کریمی
//تمرین4