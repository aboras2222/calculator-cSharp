using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, r;
            Console.Write("This Is a Calculator... \n \n Enter the first number :");

            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("                        + \n");
            Console.Write( " Enter the other number :");
            y = Convert.ToDouble(Console. ReadLine());

        
            r = x + y;
            Console.WriteLine("\n");
            Console.Write("                        =");
            Console.WriteLine(r);
            Console.WriteLine("\n Thanks for using my Calculator . ");
            Console.WriteLine("\n \n                                                                        ENG.Abouras.");
            Console.ReadKey();
        }
    }
}
