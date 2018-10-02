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
            //}//SEGUNDA PARTE DEL EJERCICIO

            //if (saldo >= 0)
            //{
            //    Console.WriteLine("Bienvenido!");
            //}//TERCERA PARTE

            //if (vip == 1 && saldo >= 0)
            //{
            //    Console.WriteLine("Bienvenido!");
            //}//CUARTA PARTE


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


            //int num1, num2;
            //Console.WriteLine("Escribe dos números entre 25 y 75");
            //num1 = Int32.Parse(Console.ReadLine());num2 = Int32.Parse(Console.ReadLine());
            //int num1un, num1dec, num2un, num2dec;
            //num1un = num1 % 10;num2un = num2 % 10;
            //num1dec = num1 / 10;num2dec = num2 / 10;
            //if ((num1 < 25 || num1 > 75)||(num2<25||num2>75))
            //{
            //    Console.WriteLine("Número de entrada no válido");
            //}
            //else if (num1un == num2un || num1un == num2dec || num1dec == num2un || num1dec == num2dec)
            //{
            //    Console.WriteLine("Ambos números comparten algun dígito");
            //}
            //else
            //{
            //    Console.WriteLine("Ambos números no comparten ningún dígito");
            //}


            //int puesto;
            //Console.WriteLine("Escribe tu puesto en la carrera");
            //puesto = Int32.Parse(Console.ReadLine());
            ////if (puesto == 1)
            ////{
            ////    Console.WriteLine("Felicidades,¡ganaste!");
            ////}
            ////else if (puesto <= 0)
            ////{
            ////    Console.WriteLine("Comando no válido");
            ////}
            //else
            //{
            //    Console.WriteLine("Lo importante es participar(PERDEDOR!!)");
            //}

            //int puesto;
            //Console.WriteLine("Escribe tu puesto en la carrera");
            //puesto = Int32.Parse(Console.ReadLine());
            //if (puesto == 1)
            //{
            //    Console.WriteLine("Felicidades,¡medalla de oro!");
            //}
            //else if (puesto == 2)
            //{
            //    Console.WriteLine("Medalla de plata");
            //}
            //else if (puesto == 3)
            //{
            //    Console.WriteLine("Medalla de bronce");
            //}
            //else if (puesto <= 0)
            //{
            //    Console.WriteLine("Comando no válido");
            //}
            //else
            //{
            //    Console.WriteLine("Lo importante es participar(PERDEDOR!!)");
            //}


            //int puesto;
            //Console.WriteLine("Escribe tu puesto en la carrera");
            //puesto = Int32.Parse(Console.ReadLine());
            //switch (puesto)
            //{
            //    case 1:
            //        Console.WriteLine("Eres medalla de oro,¡felicidades!");
            //        break;
            //    case 2:
            //        Console.WriteLine("Eres medalla de plata");
            //        break;
            //    case 3:
            //        Console.WriteLine("Eres medalla de bronce");
            //        break;
            //    default:
            //        Console.WriteLine("Lo importante es participar");
            //        break;
            //}


            //int puesto;
            //Console.WriteLine("Escribe tu puesto en la carrera");
            //puesto = Int32.Parse(Console.ReadLine());
            //switch (puesto)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //        Console.WriteLine("Felicidades, sube al podio");
            //        break;

            //    default:
            //        Console.WriteLine("Se acabó la carrera");
            //        break;
            //}


            //int puesto;
            //Console.WriteLine("Escribe tu puesto en la carrera");
            //puesto = Int32.Parse(Console.ReadLine());
            //if (puesto == 1 || puesto == 2 || puesto == 3)
            //{
            //    Console.WriteLine("Sube al podio");
            //}
            //else
            //{
            //    Console.WriteLine("Se acabó la carrera");
            //}


            //int edad;
            //Console.WriteLine("Escribe tu edad");
            //edad = Int32.Parse(Console.ReadLine());
            //if (edad <= 8)
            //{
            //    Console.WriteLine("Pasa al tobogan");
            //}
            //else
            //{
            //    Console.WriteLine("Eres demasiado mayor para esta mierda");
            //}


            //string dia;
            //Console.WriteLine("Escribe que día de la semana es");
            //dia= Console.ReadLine();
            //switch (dia)
            //{
            //    case "sabado":
            //    case "domingo":
            //        Console.WriteLine("ES FIN DE SEMANA");
            //        break;
            //    default:
            //        Console.WriteLine("Es entresemana chumacho");
            //        break;
            //}


            //string dia;
            //Console.WriteLine("Escribe que día de la semana es");
            //dia = Console.ReadLine();
            //if (dia == "domingo" || dia == "sabado")
            //{
            //    Console.WriteLine("Es fin de semana");
            //}
            //else
            //{
            //    Console.WriteLine("Es entresemana");
            //}


            //int num;
            //Console.WriteLine("Escribe un número");
            //num = Int32.Parse(Console.ReadLine());
            //if (num < 0)
            //{
            //    Console.WriteLine("El valor absoluto de " + num + " es " + num * -1);
            //}
            //else
            //{
            //    Console.WriteLine(num);
            //}


            //int hel;
            //double precio = 2;
            //Console.WriteLine("¿Cuantos helados quieres?");
            //hel = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Te llevas " + (hel + hel / 10) + " helados, y el precio es " + hel * precio);



            //double num, div;
            //Console.WriteLine("Escribe el número que quieras dividir");
            //num = Double.Parse(Console.ReadLine());
            //Console.WriteLine("Y ahora el dividendo");
            //div = Double.Parse(Console.ReadLine());
            //if (div == 0)
            //{
            //    Console.WriteLine("No se puede dividir por 0");
            //}
            //else
            //    Console.WriteLine("El resultado es "+num / div);



            //int año;
            //Console.WriteLine("Escribe el año que quieras saber si es bisieto");
            //año = Int32.Parse(Console.ReadLine());

            //if ((año % 4 == 0&&año%100!=0)||año%400==0)//TE HA COSTADO MAJO
            //{
            //    Console.WriteLine("Es año bisiesto");
            //}
            //else 
            //{
            //    Console.WriteLine("No es año bisiesto");
            //}



            
            Console.WriteLine("Elige entre estas opciones(pulsa una tecla)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("a:Tomar otra birra");
            Console.WriteLine("b:Irse a casa");
            Console.WriteLine("c:Ir a dormir");
            Console.WriteLine();
            string bar = Console.ReadLine();
            if (bar == "a")
            {
                Console.WriteLine("Pues a tomar otra!!");
            }
            else if (bar =="b")
            {
                Console.WriteLine("Pues vamos a casita :(");
            }
            else if (bar == "c")
            {
                Console.WriteLine("A dormir la mona");
            }
            else
            {
                Console.WriteLine("No te entiendo tío");
            }




            














            Console.ReadKey();
        }
    }
}
