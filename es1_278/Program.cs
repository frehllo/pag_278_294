using System;
using System.Collections.Generic;

namespace es1_278
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti numeri vuoi inserire?");
            double numeri = double.Parse(Console.ReadLine());
            List<double> numerilista = new List<double>();
            List<double> doppi = new List<double>();
            for(int i = 0; i < numeri; i++)
            {
                Console.WriteLine("Inserisci un numero:");
                double n = double.Parse(Console.ReadLine());
                if(numerilista.Contains(n))
                {
                    doppi.Add(n);
                }
                numerilista.Add(n);
                
            }
            Console.WriteLine("Questi sono i doppi");
            for (int i = 0; i < doppi.Count; i++)
            {                
                Console.WriteLine(doppi[i]);
            }
        }
    }
}
