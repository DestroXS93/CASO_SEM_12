using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            bool valor = true;
            while (valor)
            {
                Console.Clear();
                Console.WriteLine("********************************************");
                Console.WriteLine("\t Menu Principal");
                Console.WriteLine("********************************************");
                Console.WriteLine("[1] Sumatoria de numeros naturales");
                Console.WriteLine("[2] Sumatoria de numeros pares");
                Console.WriteLine("[3] Sumatoria de numeros multiplos de 5");
                Console.WriteLine("[4] Factorial");
                Console.WriteLine("[5] Tabla de multiplicar de N");
                Console.WriteLine("[6] Tablas de multiplicar 2-9");
                Console.WriteLine("[7] Potencia");
                Console.WriteLine("[8] Salir");
                Console.WriteLine("********************************************");
                Console.Write("Ingrese la opcion [1-8]");
                opc = int.Parse(Console.ReadLine());   
                switch(opc)
                {
                    case 1:
                        Console.WriteLine("***Sumatoria de numeros naturales***");
                        int N, S = 0 ;
                        Console.WriteLine("ingresar el numero de la serie: ");
                        N=int.Parse(Console.ReadLine());
                        for (int c=1; c <= N; c++)
                        {
                            S = S + c;
                        }
                        Console.WriteLine("La sumatoria es: ", +S);
                        break;
                    case 2:
                        Console.WriteLine("***Sumatoria de numeros pares***");
                        int N1, S1 = 0;
                        Console.WriteLine("ingresar el numero de la serie: ");
                        N1 = int.Parse(Console.ReadLine());
                        for (int c = 2; c <= N1 *2; c=c+2)
                        {
                            S1 = S1 + c;
                        }
                        Console.WriteLine("La sumatoria es: " + S1);
                        break;
                    case 3:
                        Console.WriteLine("***Sumatoria de numeros multiplos de 5***");
                        int N2, S2 = 0;
                        Console.WriteLine("Ingresar el numero de la serie: ");
                        N2 = int.Parse(Console.ReadLine());
                        for (int c = 5; c <= N2 * 5; c += 5)
                        {
                            S2 = S2 + c;
                        }
                        Console.WriteLine("La sumatoria es: " + S2);
                        break;

                    case 4:
                        Console.WriteLine("Factorial");
                        int N3;
                        long F = 1;
                        Console.WriteLine("Ingresar el numero: ");
                        N3 = int.Parse(Console.ReadLine());
                        for (int c = 1; c <= N3; c++)
                        {
                            F = F * c;
                        }
                        Console.WriteLine("El factorial es: " + F);
                        break;

                    case 5:
                        Console.WriteLine("***Tabla de multiplicar de N***");
                        int N4;
                        Console.WriteLine("Ingresar el numero: ");
                        N4 = int.Parse(Console.ReadLine());
                        for (int c = 1; c <= 12; c++)
                        {
                            Console.WriteLine(N4 + " x " + c + " = " + (N4 * c));
                        }
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        Console.WriteLine("Gracias por usar el sistema");
                        valor = false;
                        break;

                    default:
                        Console.WriteLine("Error, valor no valido");
                        break;
                }

                Console.ReadKey();
            }

             }
        }
    }
