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
            // welcome the user
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the temperature converter");
            Console.WriteLine();
            Console.WriteLine("Press enter to begin");
            Console.ReadKey();
            Dice();
        }

        private static void Dice()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Please Enter how many times to roll");
            try
            {
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
                Console.ReadKey();
                again();
            }
            catch (Exception e)
            {
                Console.Clear();
                // output an error nessage
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error! " + e.Message);
                Console.ReadKey();
                again();
            }
        }

        private static void again()
        {
            Console.Clear();
            Console.WriteLine("if you wish to rerun the program press 'y' otherwise press 'n' to exit.");
            string usercommand = Console.ReadLine().ToLower();
            if (usercommand == "y")
            {

                Dice();

            }
            else if (usercommand == "n")
            {
                exit();
            }
        }

        private static void exit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using my program");
            Console.WriteLine("Find more interesting projects at my GitHub Repository: bit.ly/2YDCMYQ ");
            Console.WriteLine();
            Console.WriteLine("Program Developed by Jordan W Sparkes");
            Console.WriteLine("Program Developed using Visual Studio 2019 Community Edition");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}



