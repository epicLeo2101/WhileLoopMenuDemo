using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5WhileLoopMenuDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //in the main method we'll work with the while loop

            bool Running = true;
            int userManuSelection;

            while (Running == true) //Friendly reminder that "==" is short to is equal. But you can just leave it to (Running) and the computer will assume that is equal to true.
            {
                Console.Clear();
                Console.WriteLine("Please select an option in the menu below: \n");
                //Write code


                userManuSelection = Convert.ToInt32(Console.ReadLine());

                //Use the switch method 
                switch (userManuSelection) //<<<---argument
                {
                    case 1: //<<--- you can change the number to words but need to be in Quotation mark
                        Credit();
                        break;

                    case 2:
                        Intruduction();
                        break;

                    case 3:
                        PlayGame();
                        break;


                }

            }
        }

        //Start in the program class


        //Creating credits
        public static void Credit()
        {
            Console.Clear();
            Console.WriteLine("This was created by epicLeo2101");
            Console.WriteLine("\nPress Enter to exit to main menu...");
            Console.ReadLine();
        }

        public static void Intruduction()
        {
            //Creating an intruction
            Console.Clear();
            Console.WriteLine("...Game introduction...");
            Console.WriteLine("\nPress enter to exit to menu...");
            Console.ReadLine();
        }

        public static void PlayGame()
        {
            Console.Clear();
            Console.WriteLine("Playgame...");
            Console.WriteLine("...");
        }

    }         //IS NOT FINISH BUT IS PRETTY MUCH THE JITZ OF IT
}
