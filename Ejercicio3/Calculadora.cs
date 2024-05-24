namespace Nieves_Juan_Calculadora
{
    public class Calculadora
    {
        public double PrimerDigito{get;set;}
        public double SegundoDigito{get;set;}

        public double Suma()
        {
            return PrimerDigito + SegundoDigito;
        }

        public double Resta()
        {
            return PrimerDigito - SegundoDigito;
        }

        public double Multiplicacion()
        {
            return PrimerDigito * SegundoDigito;
        }

        public double Division()
        {
            return PrimerDigito / SegundoDigito;
        }
    }

}