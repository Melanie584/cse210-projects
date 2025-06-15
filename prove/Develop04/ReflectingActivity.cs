using System;
using System.Threading;

namespace MindfulnessApp.Activities
{
    public class ReflectingActivity
    {
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Reflecting Activity");
            Console.WriteLine();
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
            Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.WriteLine();

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

            Console.WriteLine("Prepare to begin in...");
            ShowCountdown(5);
            Console.Clear();

            var promptRepo = new PromptRepository();
            string prompt = promptRepo.GetRandomPrompt();

            Console.WriteLine("Reflect on the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine();

            Console.WriteLine("Press Enter when you are ready to continue...");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
            Console.WriteLine("You may begin in: ");
            ShowCountdown(5);
            Console.Clear();

            Console.WriteLine("How did you feel when it was completed?");
            ShowSpinner(7);
            Console.WriteLine("What is your favorite thing about this experience?");
            ShowSpinner(7);
            Console.WriteLine("");

            ShowSpinner(3);
            Console.WriteLine();
            Console.WriteLine("Great job! You have completed your reflection session.");
            ShowSpinner(10);
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