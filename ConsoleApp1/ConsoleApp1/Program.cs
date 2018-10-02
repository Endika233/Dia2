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
            { Console.WriteLine("Los números son iguales."); }//EL ; ANTES DE LAS LLAVES
            else
            { Console.WriteLine("Los números no son iguales"); }*/


            /*int num1;//LAS VARIABLES AL PRINCIPIO PARA TENERLAS LOCALIZADAS
            Console.WriteLine("Introduce un número");
            num1 = Int32.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            { Console.WriteLine("El número es par."); }
            else
            { Console.WriteLine("El número es impar"); }*/


            /*int num1;
            Console.WriteLine("Escribe un número del 1 al 7");
            num1 = Int32.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                Console.WriteLine("Ese número corresponde al día lunes");
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Ese número corresponde al día martes");
            }
            else if (num1 == 3)
            {
                Console.WriteLine("Ese número corresponde al día miércoles");
            }
            else if (num1 == 4)
            {
                Console.WriteLine("Ese número corresponde al día jueves");
            }
            else if (num1 == 5)
            {
                Console.WriteLine("Ese número corresponde al día viernes");
            }
            else if (num1 == 6)
            {
                Console.WriteLine("Ese número corresponde al día sábado");
            }
            else if (num1 == 7)//PODRÍAS PONER SOLO ELSE, PERO SI ALGUIEN PUSIERA UN 8 DIRÍA DOMINGO
            {
                Console.WriteLine("Ese número corresponde al día domingo");
            }
            else
            {
                Console.WriteLine("Ese número no es correcto");
            }*/


            int num1;
            Console.WriteLine("Escribe un número de 1 al 12");
            num1 = Int32.Parse(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    Console.WriteLine("Ese número corresponde al mes de enero");
                    break;
                case 2:
                    Console.WriteLine("Ese número corresponde al mes de febrero");
                    break;
                case 3:
                    Console.WriteLine("Ese número corresponde al mes de marzo");
                    break;
                case 4:
                    Console.WriteLine("Ese número corresponde al mes de abril");
                    break;
                case 5:
                    Console.WriteLine("Ese número corresponde al mes de mayo");
                    break;
                case 6:
                    Console.WriteLine("Ese número corresponde al mes de junio");
                    break;
                case 7:
                    Console.WriteLine("Ese número corresponde al mes de julio");
                    break;
                case 8:
                    Console.WriteLine("Ese número corresponde al mes de agosto");
                    break;

                case 9:
                    Console.WriteLine("Ese número corresponde al mes de septiembre");
                    break;
                case 10:
                    Console.WriteLine("Ese número corresponde al mes de octubre");
                    break;
                case 11:
                    Console.WriteLine("Ese número corresponde al mes de noviembre");
                    break;
                case 12:
                    Console.WriteLine("Ese número corresponde al mes de diciembre");
                    break;
                default:
                    Console.WriteLine("Ese número no es correcto");
                    break;
            }










            /*double peso, altura;
            Console.WriteLine("Escribe tu altura");
            altura = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe tu peso");
            peso = Int32.Parse(Console.ReadLine());*/


            Console.ReadKey();
        }
    }
}
