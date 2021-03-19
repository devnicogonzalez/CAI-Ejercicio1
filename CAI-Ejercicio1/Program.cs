using CAICalculadora;
using CAIValidaciones;
using System;

namespace CAIEjercicio1
{
    class MainClass
    {
       class Program
        {
            static void Main(string[] args)
            {
                bool endApp = false;
                Console.WriteLine("Bienvenido a una calculadora con C#\r");
                Console.WriteLine("------------------------\n");

                while (!endApp)
                {
                    Console.Write("Ingresa un número y presione enter: ");
                    string numInput1 = Console.ReadLine();
                    double numeroA = Validaciones.ValidarNumero(numInput1); 

                    Console.Write("Ingrese otro número y presione enter: ");
                    string numInput2 = Console.ReadLine();
                    double numeroB = Validaciones.ValidarNumero(numInput2);

                    Console.WriteLine("Elija una operación de la lista:");
                    Console.WriteLine("\ts - Suma");
                    Console.WriteLine("\tr - Resta");
                    Console.WriteLine("\tm - Multiplicación");
                    Console.WriteLine("\td - División");
                    Console.Write("Ingresa tu opción: ");

                    string op = Console.ReadLine();

                    try
                    {
                        double result = Calculadora.Operar(numeroA, numeroB, op);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("La operación que intentas realizar tiene un error matemático.\n");
                        }
                        else Console.WriteLine("El resultado es: {0:0.##}\n", result);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error.\n - Detalles: " + e.Message);
                    }

                    Console.WriteLine("------------------------\n");

                    Console.Write("Presiona 'x' y Enter para salir, o presiona otra tecla para seguir realizando operaciones: ");
                    if (Console.ReadLine() == "x") endApp = true;

                    Console.WriteLine("\n"); 
                }
                return;
            }
        }
    }
}
