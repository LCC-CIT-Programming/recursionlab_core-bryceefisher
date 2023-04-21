using System;

namespace TriangularNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //For loop to call triangular nums for the first 10 triangular numbers
            for (int i = 1; i < 11; i++)
            {
                //Write nums to the console
                Console.WriteLine($"Triangular Number {i}: {TriangularNums(i)}");
            }
        }
        //Method to determine triangular nums
        public static int TriangularNums(int n)
        {
            //if n is equal to 1 return 1
            if (n == 1)
            {
                return 1;
            }
            //else return the current value of n plus a recursive call to the method with n-1 as the param
            else
            {
                return n += TriangularNums(n - 1);
            }
        }

    }
    
}


