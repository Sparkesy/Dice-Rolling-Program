using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter how many times to roll");
            int usernumber = int.Parse(Console.ReadLine());
            // create an empty array (6 elements, one for each dice number).
            int[] diceRolls = { 0, 0, 0, 0, 0, 0 };

            // create a random number generator
            Random rnd = new Random();
            // roll  times
            for (int i = 1; i <= usernumber; i++)
            {
                // roll the dice
                int roll = rnd.Next(0, 6); //generates between 0 and 5
                // add one to that diceroll
                diceRolls[roll] += 1;
            }
            // output results
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("After " + usernumber + " dice rolls, here are the results");
            // loop over the array outputting results to the console
            for (int i = 0; i < diceRolls.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write((i + 1) + " was rolled  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(diceRolls[i] + " times");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("To end the program please type 'exit' :-)");
            string userSelect = Console.ReadLine();
            if (userSelect == "exit")
            {
                {
                    Environment.Exit(0);
                }
            }
                // prevent the console from closing
                Console.ReadKey();
            }
        }
    }
    

