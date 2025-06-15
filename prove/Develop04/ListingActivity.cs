using System;
using System.Collections.Generic;

namespace MindfulnessApp.Activities
{
    public class ListingActivity
    {
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Listing Activity");
            Console.WriteLine("");
            Console.WriteLine("This activity will help you refelct on the good things in your life by having you list as many things as you can in a certain area");
            Console.WriteLine("");

            int duration;
            while (true)
            {
                Console.Write("How long, in seconds, would you like for your session? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out duration) && duration > 0)
                {
                    break;
                }
                Console.WriteLine("Please enter a valid positive number.");
            }

            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(3);

            var ListingPromptRepo = new ListingPromptRepository();
            string prompt = ListingPromptRepo.GetRandomPrompt();

            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine();
            Console.WriteLine("You may begin in...");
            ShowCountdown(5);

            Console.WriteLine();
            Console.WriteLine("Start listing now! Press Enter after each item:");

            int count = 0;
            DateTime endTime = DateTime.Now.AddSeconds(duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                if (response != "")
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"You listed {count} items. Great Job!");
            ShowSpinner(3);
            Console.Clear();

        }
        private void ShowSpinner(int durationInSeconds)
        {
            char[] spinnerChars = { '|', '/', '-', '\\' };
            int spinnerIndex = 0;
            int totalCycles = durationInSeconds * 4;

            for (int i = 0; i < totalCycles; i++)
            {
                Console.Write(spinnerChars[spinnerIndex]);
                Thread.Sleep(250);
                Console.Write("\b \b");
                spinnerIndex = (spinnerIndex + 1) % spinnerChars.Length;
            }
        }
            private void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}