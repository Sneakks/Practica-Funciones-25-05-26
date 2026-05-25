using System;

namespace PromedioEstudiantil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad;

            Console.WriteLine("=== SISTEMA MODULAR DE PROMEDIO ESTUDIANTIL ===");

            cantidad = PedirCantidadNotas();

            double[] notas = new double[cantidad];

            IngresarNotas(notas);

            double promedio = CalcularPromedio(notas);

            MostrarResultado(promedio);

            Console.ReadKey();
        }

        
        static int PedirCantidadNotas()
        {
            int cantidad;

            do
            {
                Console.Write("Ingrese la cantidad de notas: ");
                cantidad = Convert.ToInt32(Console.ReadLine());

                if (cantidad <= 0)
                {
                    Console.WriteLine("La cantidad debe ser mayor que 0.");
                }

            } while (cantidad <= 0);

            return cantidad;
        }

        
        static void IngresarNotas(double[] notas)
        {
            for (int i = 0; i < notas.Length; i++)
            {
                do
                {
                    Console.Write($"Ingrese la nota #{i + 1}: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());

                    if (notas[i] < 0 || notas[i] > 100)
                    {
                        Console.WriteLine("La nota debe estar entre 0 y 100.");
                    }

                } while (notas[i] < 0 || notas[i] > 100);
            }
        }

        
        static double CalcularPromedio(double[] notas)
        {
            double suma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }

            return suma / notas.Length;
        }

        // Función para mostrar resultado
        static void MostrarResultado(double promedio)
        {
            Console.WriteLine("\n=== RESULTADO ===");
            Console.WriteLine($"Promedio final: {promedio:F2}");

            if (promedio >= 60)
            {
                Console.WriteLine("Estado: APROBADO");
            }
            else
            {
                Console.WriteLine("Estado: REPROBADO");
            }
        }
    }
}