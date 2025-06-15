using System;
using MindfulnessApp.Activities;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "4")
            {
                Console.WriteLine("1. Start breathing activity");
                Console.WriteLine("2. Start reflecting activity");
                Console.WriteLine("3. Start listing activity");
                Console.WriteLine("4. Quit");

                Console.Write("Select a choice from the menu: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    var breathing = new BreathingActivity();
                    breathing.Start();
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    var reflecting = new ReflectingActivity();
                    reflecting.Start();
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    var listing = new ListingActivity();
                    listing.Start();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again");
                }
            }
        }
    }
}