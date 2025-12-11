using System;
using System.Collections.Generic;

namespace Ejercicio4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> frutas = new List<string> { "Manzana", "Banana", "Cereza", "Durazno" };

            frutas.Sort();

            Console.WriteLine("La lista ordenada es: ");
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
        }
    }
}
