namespace Promedio
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int numero1 = 0, numero2=0, numero3=0, prom=0;
            Console.WriteLine("Calcular el promedio de los 3 numeros");
            Console.WriteLine("Ingrese el primer valor:");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor:");
            numero2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Ingrese el tercer valor:");
             numero3 = Convert.ToInt32(Console.ReadLine());

             prom=(numero1+numero2+numero3)/3;
             Console.WriteLine("Los datos ingresados son: " + numero1 + " " +numero2+" "+ numero3);
             Console.WriteLine("El promedio de los numeros ingresados es: " + prom);
             Console.ReadLine();
        }
    }
}