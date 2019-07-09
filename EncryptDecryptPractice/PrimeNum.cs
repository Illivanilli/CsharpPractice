using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptDecryptPractice
{
    class PrimeNum
    {
        public static int prim;
        public PrimeNum(int prim)
        {
            int p;
            
            Random Rand = new Random();
            for (; ; )
            {
                p = Rand.Next(1000, 2000000 + 1);

                if (p % 2 == 0) continue;
                if (IsProbablyPrime(p, num_tests)) return prim;
            }
        }
        
    }
}
