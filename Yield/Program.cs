using System;
using System.Collections.Generic;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = Potencia(9, 2);
           Teste();
 
        }


        public static void Teste() {

            var t = 0;
        
        }
        public static IEnumerable<int> Potencia(int numero, int exponente)
        {
            int resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado = resultado * numero;
                yield return resultado;
            }
        }
    }



    
}
