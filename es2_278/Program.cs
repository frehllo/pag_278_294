using System;
using System.Collections.Generic;

namespace es2_278
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti numeri vuoi inserire?");
            double numeri = double.Parse(Console.ReadLine());
            List<double> lista = new List<double>();
            for(int i = 0; i < numeri; i++)
            {
                Console.WriteLine("Quale numero vuoi inserire?");
                double n = double.Parse(Console.ReadLine());
                lista.Add(n);
            }
            Console.WriteLine("I numeri in ordine crescente: ");
            lista.Sort();
            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();
        }
    }
}
