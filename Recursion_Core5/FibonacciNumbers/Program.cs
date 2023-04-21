using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop to iterate through the first 10 fibonacci numbers
            for (int i = 0; i < 10; i++)
            {
                //display the 10 numbers to the console
                Console.WriteLine($"Fib Number {i}: {FibNums(i)}");
            }
        }
       // method to determine the first 10 numbers in the fibonacci sequence
        public static int FibNums(int n)
        {
            //if n is equal to 0 return 0
            if (n == 0)
            {
                return 0;
            }
            // else if n is equal to 1 return 1
            else if (n == 1)
            {
                return 1;
            }
            //else return the current value of n by calling the method on n-1 and n-2
            else
            {
                return n = FibNums(n-1) + FibNums(n-2);
            }
        }

    }
    
}

