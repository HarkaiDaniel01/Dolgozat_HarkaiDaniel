using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sorOsszeg;
            double atloOsszeg = 0;
            double atlag;

            Console.Write("Adja meg az n értékét: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = rnd.Next(-20, 20);

            Console.WriteLine("A két dimenziós tömb:");

            for (int i = 0; i < n; i++)
            {
                sorOsszeg = 0;

                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j], 5}");
                    sorOsszeg += matrix[i, j];

                    if (i == j) atloOsszeg += matrix[i, j];
                }
                Console.WriteLine($" | Sor összeg: {sorOsszeg, 5}");
                
            }

            atlag = atloOsszeg / n;
            Console.WriteLine($"Az átlóban lévő számok átlaga: {Math.Round(atlag, 2)}");
            
            Console.ReadKey();
        }
    }
}
