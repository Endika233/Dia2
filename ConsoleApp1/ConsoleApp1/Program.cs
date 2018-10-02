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


            /*int num1;
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
            }*/



            /*double nota;
            Console.WriteLine("Introduce tú nota.");
            nota = Double.Parse(Console.ReadLine());
            if (nota < 5&&nota>=0)
            {
                Console.WriteLine("Suspenso.");
            }
            else if (nota >= 5 && nota < 6)
            {
                Console.WriteLine("Aprobado");
            }
            else if (nota >= 6 && nota < 7)
            {
                Console.WriteLine("Bien.");
            }
            else if (nota>=7&&nota<9.5)
            { Console.WriteLine("Notable."); }
            else if (nota >= 9.5 &&nota<=10) {
            Console.WriteLine("Sobresaliente.");}
            else
            {
                Console.WriteLine("Datos no válidos.");
            }*/


            //double peso, altura, imc;
            //Console.WriteLine("Escribe tu altura en metros");
            //altura = Double.Parse(Console.ReadLine());
            //Console.WriteLine("Escribe tu peso");
            //peso = Double.Parse(Console.ReadLine());
            //imc = peso / Math.Pow(altura, 2);
            //if (imc == 0)
            //{
            //    Console.WriteLine("Estas muerto");
            //}
            //else if (imc > 0 && imc <= 16)
            //{
            //    Console.WriteLine("Delgadez severa");
            //}
            //else if (imc >= 16 && imc < 17)
            //{
            //    Console.WriteLine("Delgadez moderada");
            //}
            //else if (imc >= 17 && imc < 18.5)
            //{
            //    Console.WriteLine("Delgadez delgadez aceptable");
            //}
            //else if (imc >= 18.5 && imc < 25)
            //{
            //    Console.WriteLine("Peso normal");
            //}
            //else if (imc >= 25 && imc < 30)
            //{
            //    Console.WriteLine("Sobrepeso");
            //}
            //else if (imc >= 30 && imc < 35)
            //{
            //    Console.WriteLine("Obeso tipo I");
            //}
            //else if (imc >= 35 && imc <= 40)
            //{
            //    Console.WriteLine("Obeso tipo II");

            //}
            //else if (imc > 40)
            //{
            //    Console.WriteLine("Obeso tipo III");
            //}



            //Double entr, vip, saldo;
            //Console.WriteLine("¿Ha pagado entrada? 1 o 0");//1 sera SÍ, 0 NO
            //entr = Double.Parse(Console.ReadLine());
            //Console.WriteLine("¿Es VIP? 1 o 0");
            //vip = Double.Parse(Console.ReadLine());
            //Console.WriteLine("Introduzca saldo cliente.");
            //saldo = Double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //if (entr == 1)//Las barras verticales altgr+1, OR
            //{
            //    Console.WriteLine("Bienvenido");
            //}
            //else if (entr == 0)
            //{
            //    Console.WriteLine("Tiene que pagar entrada");
            //}
            //else
            //{ Console.WriteLine("Base de datos incorrecta"); }//PRIMERA PARTE EJERCICIO

            //if (vip == 1 )
            //{
            //    Console.WriteLine("Bienvenido, ¡que pase un buen día!");
            //}
            //else 
            //{
            //    Console.WriteLine("Bienvenido");
            //}

            //if (saldo >= 0)
            //{
            //    Console.WriteLine("Bienvenido!");
            //}

            //if (vip == 1 && saldo >= 0)
            //{
            //    Console.WriteLine("Bienvenido!");
            //}


            //Console.WriteLine("Escribe dos números.");
            //double num1 = Double.Parse(Console.ReadLine()), num2 = Double.Parse(Console.ReadLine());
            //Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            //Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            //Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
            //Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            //Console.WriteLine("La media de " + num1 + " y " + num2 + " es " + (num1 + num2) / 2);
            //if (num1 > num2)
            //{
            //    Console.WriteLine("El número más alto es " + num1);
            //    Console.WriteLine("Y el más bajo es " + num2);
            //}
            //if (num2 > num1)
            //{
            //    Console.WriteLine("El número más alto es " + num2);
            //    Console.WriteLine("Y el mas bajo es " + num1);
            //}


            //Double num1, num2, num3;
            //Console.WriteLine("Escribe tres números");
            //num1 = Double.Parse(Console.ReadLine());
            //num2 = Double.Parse(Console.ReadLine());
            //num3 = Double.Parse(Console.ReadLine());
            //if (num1 + num2 == num3)
            //{
            //    Console.WriteLine(num1 + " + " + num2 + " = "+num3);
            //}
            //else
            //{
            //    Console.WriteLine(num1 + " + " + num2 + " != " + num3);
            //}

            //long segundos, minutos, horas;
            //Console.WriteLine("Escribe los segundos a convertir");
            //segundos=Int64.Parse(Console.ReadLine());
            //horas = (segundos / 3600);
            //minutos = (segundos / 60)%60;
            //Console.WriteLine("Eso son "+horas+" h "+minutos+" min "+segundos%60+" seg");


            //Console.WriteLine("Escribe tres números");
            //int num1 = Int32.Parse(Console.ReadLine()), num2 = Int32.Parse(Console.ReadLine()), num3 = Int32.Parse(Console.ReadLine());
            //if ((num1 + 20) == num2)
            //{
            //    Console.WriteLine(num2 + " - 20 = "+num1);
            //}
            // if ((num1 + 20) == num3)
            //{
            //    Console.WriteLine(num3 + " - 20 = " + num1);
            //}
            // if ((num2 + 20) == num1)
            //{
            //    Console.WriteLine(num1 + " - 20 = " + num2);
            //}
            // if ((num2 + 20) == num3)
            //{
            //    Console.WriteLine(num3 + " - 20 = " + num2);
            //}
            // if ((num3 + 20) == num1)
            //{
            //    Console.WriteLine(num1 + " - 20 = " + num3);
            //}
            // if ((num3 + 20) == num2)
            //{
            //    Console.WriteLine(num2 + " - 20 = " + num3);
            //}

            //int num1, num2;
            //Console.WriteLine("Escribe dos números");
            //num1 = Int32.Parse(Console.ReadLine()); num2 = Int32.Parse(Console.ReadLine());
            //if (num1 == num2)
            //{
            //    Console.WriteLine("0");
            //}
            //if (num1 % 6 == num2 % 6)
            //{
            //    if (num1 < num2)
            //    {
            //        Console.WriteLine(num1 + " es más pequeño que " + num2);
            //    }
            //    else if (num1 == num2)
            //    {
            //        Console.WriteLine("Los dos números son iguales");
            //    }
            //    else
            //    {
            //        Console.WriteLine(num2 + " es más pequeño que " + num1);
            //    }
            //}
            //else if (num1 < num2)
            //{
            //    Console.WriteLine("El número más grande es " + num2);
            //}
            //else
            //{
            //    Console.WriteLine("El número más grande es " + num1);
            //}


            int num1, num2;
            Console.WriteLine("Escribe dos números entre 25 y 75");
            num1 = Int32.Parse(Console.ReadLine());num2 = Int32.Parse(Console.ReadLine());
            int num1un, num1dec, num2un, num2dec;
            num1un = num1 % 10;num2un = num2 % 10;
            num1dec = num1 / 10;num2dec = num2 / 10;
            if ((num1 < 25 || num1 > 75)||(num2<25||num2>75))
            {
                Console.WriteLine("Número de entrada no válido");
            }
            else if (num1un == num2un || num1un == num2dec || num1dec == num2un || num1dec == num2dec)
            {
                Console.WriteLine("Ambos números comparten algun dígito");
            }
            else
            {
                Console.WriteLine("Ambos números no comparten ningún dígito");
            }
       



            Console.ReadKey();
        }
    }
}
