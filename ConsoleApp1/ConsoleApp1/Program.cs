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
            /*Console.WriteLine("Introduce dos números");
            int num1 = Int32.Parse(Console.ReadLine()), num2 = Int32.Parse(Console.ReadLine());
            if (num1 == num2) 
            { Console.WriteLine("Los números son iguales."); }
            else
            { Console.WriteLine("Los números no son iguales"); }*/


            int num1;//LAS VARIABLES AL PRINCIPIO PARA TENERLAS LOCALIZADAS
            Console.WriteLine("Introduce un número");
            num1 = Int32.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            { Console.WriteLine("El número es par."); }
            else
            { Console.WriteLine("El número es impar"); }

            Console.ReadKey();
        }
    }
}
