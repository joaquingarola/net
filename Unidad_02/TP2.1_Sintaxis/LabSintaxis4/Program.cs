﻿using System;

namespace LabSintaxis4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ej01();
            //ej02();
            //ej03();
            //ej04();
            //ej05();
            //ej06();
            //ej07();
            //ej08();
            //ej09();
        }
        static void ej01()
        {
            Console.WriteLine("Ingrese el primer valor:");
            int valor1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor:");
            int valor2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la suma de " + valor1 + " y " + valor2 + " es " + (valor1 + valor2));
        }
        static void ej02()
        {
            Console.WriteLine("Ingrese año a evaluar");
            int año = Int32.Parse(Console.ReadLine());
            if(año%4 == 0)
            {
                if(año%100 == 0)
                {
                    if(año%400 == 0)
                        Console.WriteLine("El año es bisiesto");
                    else
                        Console.WriteLine("El año no es bisiesto");
                }
                else
                    Console.WriteLine("El año es bisiesto");
            }
            else
                Console.WriteLine("El año no es bisiesto");
        }
        static void ej03()
        {
            Console.WriteLine("Sucesión de Fibonacci");
            Console.WriteLine("Cuantos elementos desea calcular?");
            int n = Int32.Parse(Console.ReadLine());
            int a = 0, b = 1, c;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(a);
                c = a + b;
                a = b;
                b = c;
            }
        }
        static void ej04()
        {
            Console.WriteLine("Números pares entre 1 y 100");
            for(int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void ej05()
        {
            String nombreMes;
            int numeroMes;
            Console.WriteLine("Ingrese un mes");
            nombreMes = Console.ReadLine().ToUpper();

            switch (nombreMes)
            {
                case "ENERO":
                    numeroMes = 1;
                    Console.WriteLine("{0}: {1}", nombreMes, numeroMes);
                    break;

                case "FEBRERO":
                    numeroMes = 2;
                    Console.WriteLine("{0}: {1}", nombreMes, numeroMes);
                    break;

                case "MARZO":
                    numeroMes = 3;
                    Console.WriteLine("{0}: {1}", nombreMes, numeroMes);
                    break;

                case "ABRIL":
                    numeroMes = 4;
                    Console.WriteLine("{0}: {1}", nombreMes, numeroMes);
                    break;

                case "MAYO":
                    numeroMes = 5;
                    Console.WriteLine("{0}: {1}", nombreMes, numeroMes);
                    break;

                case "JUNIO":
                    numeroMes = 6;
                    Console.WriteLine("{0}: {1}", nombreMes, numeroMes);
                    break;

                case "JULIO":
                    numeroMes = 7;
                    Console.WriteLine("{0}: {1}", nombreMes, numeroMes);
                    break;

                case "AGOSTO":
                    numeroMes = 8;
                    Console.WriteLine("{0}: {1}", nombreMes, numeroMes);
                    break;

                case "SEPTIEMBRE":
                    numeroMes = 9;
                    Console.WriteLine("{0}: {1}", nombreMes, numeroMes);
                    break;

                case "OCTUBRE":
                    numeroMes = 10;
                    Console.WriteLine("{0}: {1}", nombreMes, numeroMes);
                    break;

                case "NOVIEMBRE":
                    numeroMes = 11;
                    Console.WriteLine("{0}: {1}", nombreMes, numeroMes);
                    break;

                case "DICIEMBRE":
                    numeroMes = 12;
                    Console.WriteLine("{0}: {1}", nombreMes, numeroMes);
                    break;

                default:
                    Console.WriteLine("El mes ingresado es incorrecto");
                    break;
            }
        }
        static void ej06()
        {
            string[] millares = {"", "M", "MM", "MMM"};
            string[] centenas = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] decenas = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] unidades = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VII", "IX" };
            string salida;

            Console.WriteLine("Ingrese un número entre 1 y 3999");
            int nro = Int32.Parse(Console.ReadLine());
            if(nro > 0 && nro < 4000)
            {
                int u = nro % 10; 
                nro /= 10;
                int d = nro % 10; 
                nro /= 10;
                int c = nro % 10; 
                nro /= 10;
                int m = nro % 10; 
                nro /= 10;

                salida = millares[m] + centenas[c] + decenas[d] + unidades[u];
                Console.WriteLine("El pasaje a número romano del número {0} es: {1}", nro, salida);

            }
            else
                Console.WriteLine("El número ingresado no es válido");
        }
        static void ej07()
        {
            Console.WriteLine("Ingrese cantidad de parejas de números primeros gemelos que quiere buscar");
            int cant = Int32.Parse(Console.ReadLine());
            int c = 0, nro = 1;

            while (c < cant)
            {
                nro++;
                if(esPrimo(nro))
                {
                    if (esPrimo(nro + 2))
                    {
                        c++;
                        Console.WriteLine("Pareja {0}: ({1}, {2})", c, nro, (nro+2));
                    }
                }    
            }
        }
        static bool esPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void ej08()
        {
            string ingreso, clave = ".net2022";
            bool band = false;
            int intentos = 0;
            while(intentos < 4 && !band)
            {
                intentos++;
                Console.WriteLine("Introduzca una clave");
                ingreso = Console.ReadLine();
                if(ingreso == clave)
                {
                    Console.WriteLine("Clave correcta");
                    band = true;
                }
                else
                    Console.WriteLine("Clave incorrecta. Le quedan {0} intentos", (4-intentos));
            }
        }
        static void ej09()
        {
            Console.WriteLine("Ingresa cantidad de filas");
            int f = Int32.Parse(Console.ReadLine());
            for(int i = 0; i<f; i++)
            {
                for(int j = 0; j < (f - i - 1); j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < (2 * i + 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
