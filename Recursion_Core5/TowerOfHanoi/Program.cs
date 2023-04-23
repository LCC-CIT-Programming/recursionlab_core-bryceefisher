using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            //validate user input as an int
            int discs = GetUserInput();
           //write details to the console including the number of moves required
            Console.WriteLine($"\nTower of Hanoi with {discs} disks will take {Math.Pow(2, discs) - 1} moves:\n");
           //call method to display moves to the console
            TowerMoves(discs, "left", "middle", "right");
            
            
        }
        //method to get user input from the console
        static int GetUserInput()
        {
            //create variables to use in the do while loop
            string userInput;
            int discs;
            bool isInt;
            int numTrys = 0;
            //do while loop to validate user input
            do
            {
                //if it is the first time displaying message use standard else use a more descriptive message
                Console.Write(numTrys == 0 ?"Enter a number of discs: " : "Please enter an integer: ");
                userInput = Console.ReadLine();
                isInt = int.TryParse(userInput, out discs);
                numTrys++;
            } while (!isInt);
            //return the validated num of disks
            return discs;
        }
        //method to display moves for tower of hanoi game with n disks
        static void TowerMoves(int n, string a, string b, string c)
        {
            /*if n is equal to one display base case message. This will be the last iteration but first displayed b
            do to the properties of the stack*/
            
            if (n == 1)
            {
                Console.WriteLine($"Move disc 1 from {a} tower to {b} tower");
            }
            
            else
            {
                //else call tower moves on n-1 with towers in original position
                TowerMoves(n-1, a, c, b);
                //display a message about the move
                Console.WriteLine($"Move disc {n} from {a} tower to {b} tower");
                //call towermoves again on n-1 with the position of the towers reversed
                TowerMoves(n-1, c, b, a);
            }

            
        }
    }
}



