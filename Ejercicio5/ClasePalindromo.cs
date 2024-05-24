using System;

namespace Palindromo_NievesJuan
{
    public class ClasePalindromo
    {
        public int Digito1 {get;set;}
        public int Digito2 {get;set;}
        public int Digito3 {get;set;}
        public int Digito4 {get;set;}
        public int Digito5 {get;set;}

        public string Palindromo()
        {
         if (Digito1==Digito5 & Digito2==Digito4)
         {Console.ForegroundColor = ConsoleColor.DarkGreen;
           return "Felicidades, su numero es palindromo";
         }
         else
         {  Console.ForegroundColor = ConsoleColor.DarkRed;
             return "Su numero no es palindromo, vuelve a intentarlo";
         }
         

            
        }
        
        

        
        

            
                



        
        }
    }








    


