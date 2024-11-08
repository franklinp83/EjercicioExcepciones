using System;

namespace EjercicioExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.WriteLine("\n*** Menú de Operaciones ***");
                    Console.WriteLine("1. Sumar");
                    Console.WriteLine("2. Restar");
                    Console.WriteLine("3. Multiplicar");
                    Console.WriteLine("4. Dividir");
                    Console.WriteLine("5. Salir");
                    Console.Write("Seleccione una opcion: ");
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 5)
                    {
                        continuar = false;
                        Console.WriteLine("¡Programa finalizado!");
                        break;
                    }

                    Console.Write("Ingrese el primer numero: ");
                    double numero1 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo numero: ");
                    double numero2 = double.Parse(Console.ReadLine());

                    double resultado = 0;

                    switch (opcion)
                    {
                        case 1:
                            resultado = operaciones.Sumar(numero1, numero2);
                            Console.WriteLine($"Resultado de la suma es: {resultado}");
                            break;
                        case 2:
                            resultado = operaciones.Restar(numero1, numero2);
                            Console.WriteLine($"Resultado de la resta es: {resultado}");
                            break;
                        case 3:
                            resultado = operaciones.Multiplicar(numero1, numero2);
                            Console.WriteLine($"Resultado de la multiplicacion es: {resultado}");
                            break;
                        case 4:
                            resultado = operaciones.Dividir(numero1, numero2);
                            Console.WriteLine($"Resultado de la division es: {resultado}");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Debe ingresar un numero valido.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocurrió un error: {ex.Message}");
                }
            }
        }
    }
}
