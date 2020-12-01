using System;

namespace Funzioni
{
    public class Funzione
    {
        public static int InserisciNumeroInt()
        {
            Console.Write("inserisci un numero intero: ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        public static void StampaDivisori(int n)
        {
            int i = 1;
            while (i <= n)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
                i++;
            }
        }
    }
}
