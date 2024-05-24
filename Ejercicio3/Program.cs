using System;

namespace Nieves_Juan_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el objeto calculadora
            Calculadora objCalculadora;
            objCalculadora = new();

            //Creamos la posibilidad de ingresar datos junto con la opcion de elegir
            Ingresar_Datos(objCalculadora);

            char opcionElegida;
            opcionElegida = Menu_Seleccion_Usuario();

            //Creamos, Mostrar Resultado
            double Resultado;
            Resultado = Operacion_Resultado(opcionElegida,objCalculadora);

            Console.WriteLine("El resultado de la operación es: "+ Resultado);



        }
        public static char Menu_Seleccion_Usuario()
        {
            Console.Clear();
            Console.WriteLine("A.- Suma");
            Console.WriteLine("B.- Resta");
            Console.WriteLine("C.- Multiplicación");
            Console.WriteLine("D.- División");
            Console.Write("Por favor seleccione la operacion que desea realizar: ");
            string caracter;
            caracter = Console.ReadLine();
            return char.Parse(caracter);
        }
        public static void Ingresar_Datos(Calculadora parametroCalculadora)
        {
            Console.Clear();

            string primervalor;
            Console.WriteLine("Ingrese el primer valor: ");
            primervalor = Console.ReadLine();
            parametroCalculadora.PrimerDigito = double.Parse(primervalor);

            string segundovalor;
            Console.WriteLine("Ingrese segundo valor: ");
            segundovalor = Console.ReadLine();
            parametroCalculadora.SegundoDigito = double.Parse(segundovalor);
        }
         public static double Operacion_Resultado(char caracter,Calculadora objCalculadora)
        {
            Console.Clear();

            if(caracter=='A')
            {
                return objCalculadora.Suma();
            }
            else if(caracter=='B')
            {
                return objCalculadora.Resta();
            }
            else if(caracter=='C')
            {
                return objCalculadora.Multiplicacion();
            }
            else if(caracter=='D')
            {
                return objCalculadora.Division();
            }
            
            return 0;

          
            
        }
    }
}
