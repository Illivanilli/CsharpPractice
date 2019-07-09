using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptDecryptPractice
{
    class SieveOfEratosthenes
    {
        //uses the SieveOfEratosthene to determine if a number is a prime from an array of numbers greater than 2.
        int[] nums = new int[100];  
        int[] isPrime = new int[] { };
        public SieveOfEratosthenes()
        {
            for (int i= 2; i < nums.Length; i++)  // starts at 2, and increases to length of nums.
            {
                nums[i] = i;
                for (int j = i * 2; j <= nums.Length; j += i)
                {
                    Console.WriteLine(isPrime[j]);           
                }      
            }

            

        }

       

    }
}
