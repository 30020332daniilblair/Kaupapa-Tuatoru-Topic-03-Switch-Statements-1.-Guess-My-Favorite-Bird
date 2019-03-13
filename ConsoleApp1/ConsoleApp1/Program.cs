using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Helo my name is Daniil Blair. I am the head developer of this programme.

            Console.WriteLine("Hello. Welcome to guess the bird game.");
            Console.WriteLine("You have three diferent options of birds to pick from.");
            Console.WriteLine("Your options are, Pigeon, Chicken and Parrot.");
            Console.WriteLine("If you guess correctly you will win a billion $");
            Console.WriteLine("Go ahead and select a bird");

            string bird = Console.ReadLine().ToLower();
                

            switch (bird)
            {
                case "pigeon":
                case "chicken":
                    Console.WriteLine("Na you did not get it this time sorry");
                    break;

                case "parrot":
                    Console.WriteLine("Congratulations! You are now a billionaire");
                       
                    break;

                default:
                    Console.WriteLine("That was an invalid key");
                    break;

            }

            Console.ReadLine();

        }
    }
}
