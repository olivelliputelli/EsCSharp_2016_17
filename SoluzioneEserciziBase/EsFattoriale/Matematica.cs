using System;

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
    }
}
