using System;

namespace Palindromo_NievesJuan
{
    class Program
    {
        static void Main(string[] args)
        {
             //creamos el objeto
            ClasePalindromo NumPalindromo;
            NumPalindromo = new();

            //"Tuneo" del codigo
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

        //-----------------------------------------------------------------------------------------
            Console.WriteLine("Bienvenido, aqui vamos averiguar si su numero es Palindromo o no");
            //-----------------------------------------------------------------------------------------
            Console.WriteLine("Introduzca 1re numero --> ");
            NumPalindromo.Digito1 = int.Parse(Console.ReadLine());
            //-----------------------------------------------------------------------------------------
            Console.WriteLine("Introduzca 2do numero -->");
            NumPalindromo.Digito2 = int.Parse(Console.ReadLine());
            //-----------------------------------------------------------------------------------------
             Console.WriteLine("Introduzca 3re numero -->");
             NumPalindromo.Digito3 = int.Parse(Console.ReadLine());
             //-----------------------------------------------------------------------------------------
             Console.WriteLine("Introduzca 4to numero -->");
             NumPalindromo.Digito4 = int.Parse(Console.ReadLine());
             //-----------------------------------------------------------------------------------------
             Console.WriteLine("Introduzca 5to numero -->");
             NumPalindromo.Digito5 = int.Parse(Console.ReadLine());
             //-----------------------------------------------------------------------------------------
             Console.WriteLine(NumPalindromo.Palindromo());
             



        }
    }
}
