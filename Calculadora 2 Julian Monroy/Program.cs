using Microsoft.VisualBasic.FileIO;
using System;

namespace Calculadora_2_Julian_Monroy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese la operacion que desea realizar");
            Console.WriteLine("1. suma ");
            Console.WriteLine("2. resta ");
            Console.WriteLine("3. division ");
            Console.WriteLine("4. multiplicacion ");
            Console.WriteLine("5. cuadrado/elevado ");
            Console.WriteLine("6. raiz cuadrada ");

            string operacion = Console.ReadLine();
            double resultado = 0;

            switch (operacion)
            {
                case "1":
                    Console.WriteLine("Ingrese el primer valor a sumar:");
                    int valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo valor a sumar:");
                    int valor2 = int.Parse(Console.ReadLine());
                    resultado = Operation(operacion, valor1, valor2);
                    break;

                case "2":
                    Console.WriteLine("Ingrese el primer valor a restar:");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo valor para restar:");
                    valor2 = int.Parse(Console.ReadLine());
                    resultado = Operation(operacion, valor1, valor2);
                    break;

                case "3":
                    Console.WriteLine("Ingrese el primer valor a ser dividido:");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo valor para dividir:");
                    valor2 = int.Parse(Console.ReadLine());
                    resultado = Operation(operacion, valor1, valor2);
                    break;

                case "4":
                    Console.WriteLine("Ingrese el primer valor a multiplicar:");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo valor para multiplicar:");
                    valor2 = int.Parse(Console.ReadLine());
                    resultado = Operation(operacion, valor1, valor2);
                    break;

                case "5":
                    Console.WriteLine("Ingrese el número que va a ser elevado:");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese a cuanto lo va a elevar");
                    valor2 = int.Parse(Console.ReadLine());
                    resultado = Operation(operacion, valor1, valor2);
                    break;

                case "6":
                    Console.WriteLine("Ingrese el valor que quiere sacar la raiz cuadrada:");
                    valor1 = int.Parse(Console.ReadLine());
                    resultado = Operation(operacion, valor1, 0);
                    break;

                default:
                    Console.WriteLine("Este valor no es valido, vuelva a intentar jsjs saludos");
                    break;
            }

            printMessage(resultado);

            static double Operation(string opcion, int valor1, int valor2)
            {
                switch (opcion)
                {
                    case "1":
                        return valor1 + valor2;

                    case "2":
                        return valor1 - valor2;

                    case "3":
                        return valor1 / valor2;

                    case "4":
                        return valor1 * valor2;

                    case "5":
                        return Math.Pow(valor1, valor2);

                    case "6":
                        return Math.Sqrt(valor1);

                    default:
                        return 0;
                }
            }

            static void printMessage(double resultado)
            {
                Console.WriteLine("El resultado de la operacion es: " + resultado);
            }
        }
    }
}