using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("Add meg a tömb méretét: ");
            int N = int.Parse(Console.ReadLine());

            int[] szamok = new int[N];

            Console.WriteLine("\nA tömb elemei:");

            for (int i = 0; i < N; i++) szamok[i] = rnd.Next(50, 151);

            foreach (int szam in szamok) Console.Write($"{szam} ");

            Console.WriteLine($"\n\nA legnagyobb szám: {szamok.Max()}");
            Console.WriteLine($"A legkisebb szám: {szamok.Min()}");

            Array.Sort(szamok);
            Array.Reverse(szamok);

            Console.WriteLine("\nA tömb csökkenő sorrendben:");
            foreach (int szam in szamok) Console.Write($"{szam} ");

            Console.ReadKey();
        }
    }
}
