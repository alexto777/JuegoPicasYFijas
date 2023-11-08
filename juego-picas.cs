using System;

namespace JuegoPicasYFijas
{
    partial class Program
    {
        static void Main()
        {
            
        // Generar un número secreto de cuatro dígitos
        Random random = new Random();
        int numeroSecreto = random.Next(1000, 10000);

        int intentos = 0;

        while (true)
        {
            Console.Write("Ingresa un número de cuatro dígitos: ");
            string input = Console.ReadLine();

            if (input.Length != 4 || !int.TryParse(input, out int numeroIngresado))
            {
                Console.WriteLine("Por favor, ingresa un número de cuatro dígitos.");
                continue;
            }

            intentos++;

            if (numeroIngresado == numeroSecreto)
            {
                Console.WriteLine($"¡Felicidades! Adivinaste el número secreto ({numeroSecreto}) en {intentos} intentos.");
                break;
            }

            string numeroSecretoStr = numeroSecreto.ToString();
            string numeroIngresadoStr = numeroIngresado.ToString();
            int picas = 0;
            int fijas = 0;

            for (int i = 0; i < 4; i++)
            {
                if (numeroIngresadoStr[i] == numeroSecretoStr[i])
                {
                    fijas++;
                }
                else if (numeroSecretoStr.Contains(numeroIngresadoStr[i].ToString()))
                {
                    picas++;
                }
            }

            Console.WriteLine($"Picas: {picas}, Fijas: {fijas}");
        }
        }
    }
}
