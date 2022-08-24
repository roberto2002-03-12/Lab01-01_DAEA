using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //con esto definimos un titulo a la consola
            Console.Title = "Procedimientos y funciones";
            string opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros num enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] Mostrar números primos de 2 a 10");
                Console.WriteLine("[7] Convertir de Farengel a Celcius y viceversa");
                //Console.WriteLine("[1] Suma de dos números");
                //Console.WriteLine("[1] Suma de dos números");

                //con esto el valor de input se lo pasa a opcion
                opcion = Console.ReadLine();

                //es como el switch de js, también podemos usar if
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        //lanza el evento input, para que se vuelva a leer la opcion que esta arriba
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Botando resultados...");
                        Raiz();
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", f, g, Multiplicar(f, g));
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2}", h, i, Dividir(h, i));
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Botando resultados...");
                        Primos();
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.WriteLine("Ingrese la temperatura en Farengel");
                        int far = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese la temperatura en Celcius");
                        int cel = Convert.ToInt32(Console.ReadLine());
                        CelciusYFarengel(far, cel);
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Usted a ingresado una opción invalida");
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static int Dividir(int a, int b)
        {
            return a / b;
        }

        static void CelciusYFarengel(double a, double b)
        {
            double celcius = 5*(a - 32);
            celcius = celcius / 9;

            Console.WriteLine("La temperatura de Farengel a Celcius es " + celcius);

            double farengel = (9 * b) / 5;
            farengel = farengel + 32;

            Console.WriteLine("La temperatura de Celcius a Farengel es " + farengel);
        }

        static void Raiz()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("La raíz cuadrada del número " + i + " es " + Math.Sqrt(i));
            }
        }

        static void Primos()
        {
            int valor = 0;

            for (int i = 2; i < 11; i++)
            {
                for (int j = 2; j < 11; j++)
                {
                    if (i % j == 0)
                    {
                        valor++;
                    }
                }

                if (valor >= 2)
                {
                    Console.WriteLine("El número " + i + " no es primo");
                } else
                {
                    Console.WriteLine("El número " + i + " si es primo");
                }

                valor = 0;
            }
        }
    }
}
