using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce dos números");
            int num1 = Int32.Parse(Console.ReadLine()), num2 = Int32.Parse(Console.ReadLine());
            if (num1 == num2) 
            { Console.WriteLine("Los números son iguales."); }
            else
            { Console.WriteLine("Los números no son iguales"); }

            Console.ReadKey();
        }
    }
}
