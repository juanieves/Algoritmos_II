using System;

using System;

class Program
{
    static void Main()
    {
    
        Console.Write("Ingrese su peso en kgs: ");
        double peso = Convert.ToDouble(Console.ReadLine());
        
    
        Console.Write("Ingrese su altura en mts: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        
        // Calcular el IMC
        double imc = peso / (altura * altura);
        
        // Mostrar el resultado
        Console.WriteLine($"Su IMC es: {imc:F2}");
        
        // Determinar la categoría del IMC
        if (imc < 18.5)
        {
            Console.WriteLine("Usted está bajo de peso.");
        }
        else if (imc >= 18.5 && imc < 24.9)
        {
            Console.WriteLine("Usted tiene un peso normal.");
        }
        else if (imc >= 25 && imc < 29.9)
        {
            Console.WriteLine("Usted tiene sobrepeso.");
        }
        else
        {
            Console.WriteLine("Usted tiene obesidad.");
        }
    }
}

