using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un año
        Console.WriteLine("Por favor, ingrese un año:");
        string input = Console.ReadLine();
        int year;

        // Verificar si el input es un número válido
        if (int.TryParse(input, out year))
        {
            // Determinar si el año es bisiesto
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            // Mostrar un mensaje indicando si el año es bisiesto o no
            if (isLeapYear)
            {
                Console.WriteLine($"El año {year} es bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {year} no es bisiesto.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
    }
}
