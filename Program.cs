using System;
using System.Collections.Generic;
using System.Linq;

namespace HanoiTower
{
    class HanoiTower
    {

        static int liczbaKrokow = 0;

        public static void PrzeniesDysk(int starter, int koniec, int tymczasowy, int liczbaDyskow, ref int m)
        {
            if (liczbaDyskow > 1) PrzeniesDysk(starter, tymczasowy, koniec, liczbaDyskow - 1, ref m);
            Console.WriteLine($"{starter} przeniesiony do {koniec}");
            m++;
            if (liczbaDyskow > 1) PrzeniesDysk(tymczasowy, koniec, starter, liczbaDyskow - 1, ref m);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe dyskow");
            int n = Int32.Parse(Console.ReadLine());
            PrzeniesDysk(1, 3, 2, n, ref liczbaKrokow);
            Console.WriteLine($"Całkowita liczba kroków: {liczbaKrokow}");
        }

    }
}