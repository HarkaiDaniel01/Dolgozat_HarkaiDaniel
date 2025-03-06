using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Feltölt egy 15 elemű tömböt 1 és 100 közé eső véletlenszerű számokkal. Feltöltés után a tömb elemeit a program írja ki a képernyőre egy sorba, vesszővel elválasztva! 

            Random rnd = new Random();
            int[] szamok = new int[15];

            for (int i = 0; i < szamok.Length; i++) szamok[i] = rnd.Next(1, 101);

            Console.Write("A tömb elemei: ");

            foreach (int szam in szamok) Console.Write($"{szam}, ");

            Console.ReadKey();
        }
    }
}
