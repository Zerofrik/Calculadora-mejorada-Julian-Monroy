using System;

namespace Calculadora_2_Julian_Monroy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 1;
            int resta = 2;
            int division = 3;
            int multiplicacion = 4;
            int raiz_cuadrada = 5;
            int cuadrado = 6;

            Console.WriteLine("ingrese la operacion que desea realizar");
            Console.WriteLine("1.suma 2.resta 3.division 4.multiplicacion 5.raiz cuadrada 6.cuadrado");
            int operacion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el primer valor");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo valor");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            printMessage(0);


            static double Operation(int operacion, int valor1, int valor2)
            {

                switch (operacion)
                {
                    case 1:
                        return valor1 + valor2;
                    case 2:
                        return valor1 - valor2;
                    case 3:
                        return valor1 / valor2;
                    case 4:
                        return valor1 * valor2;
                    case 5:
                        return Math.Sqrt(valor1);
                    case 6:
                        return Math.Pow(valor1, valor2);

                }
                return 0;
            }

            static void printMessage(double result)
            {
                Console.WriteLine("el resultado de la operacion es "  );
            }

        }
    }
}
