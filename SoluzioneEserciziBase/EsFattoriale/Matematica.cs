﻿using System;

namespace EsFattoriale
{
    public static class Matematica
    {
        public static ulong Fattoriale(byte n)
        {
            if (n > 64) //ulong non riesce a contenere 65!
                throw new ArgumentOutOfRangeException();

            ulong fat = 1;
            for (ulong i = 1; i <= (ulong)n; i++)
            {
                fat *= i;
            }
            return fat;
        }
        /// <summary>
        /// Fattoriale ricorsivo
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static ulong FattorialeRic(ulong n)
        {
            if (n > 64)
                throw new ArgumentOutOfRangeException();

            if (n >= 1)
                return n * FattorialeRic(n - 1);
            else
                return 1;
        }


        public static void SpostaTorre(int nDischi, int da, int a, int perMezzoDi)
        {
            if(nDischi>1)
            {
                SpostaTorre(nDischi - 1, da, perMezzoDi, a);
                SpostaDisco(da, a);
                SpostaTorre(nDischi - 1, perMezzoDi, a, da);
            }
        }
        static void SpostaDisco(int da, int a)
        {
            Console.WriteLine($"sposta un disco dalla colonna {da} alla colonna {a}");
            Console.ReadLine();
        }
    }
}
