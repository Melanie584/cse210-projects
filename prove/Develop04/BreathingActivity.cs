using System;

namespace MindfulnessApp.Activities
{
    public class BreathingActivity
    {
        public void Start()
        {
            Console.WriteLine("Welcome to the Breathing Activity");
            Console.WriteLine();
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. ");
            Console.WriteLine();

            int duration;

            while (true)
            {
                Console.Write("How long, in seconds, would you like your session to be? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out duration))
                {
                    if (duration > 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("Please enter a valid positive number");
            }

            Console.WriteLine();
            Console.WriteLine("Get ready to begin...");
            ShowSpinner(3);  // Spinner before activity

            int secondsPerCycle = 8;
            int cycles = duration / secondsPerCycle;

            for (int i = 0; i < cycles; i++)
            {
                Console.WriteLine("Breathe in...");
                for (int sec = 4; sec > 0; sec--)
                {
                    Console.Write(sec);
                    System.Threading.Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine();

                Console.WriteLine("Breathe out...");
                for (int sec = 4; sec > 0; sec--)
                {
                    Console.Write(sec);
                    System.Threading.Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Great job! You have completed your breathing session.");
            Console.WriteLine();

            Console.WriteLine("Returning to menu...");
            ShowSpinner(3);  // Spinner after activity
            Console.Clear();  // Clear screen to cleanly show menu again
        }


        public void ShowSpinner(int durationInseconds)
        {
            char[] spinnerChars = { '|', '/', '-', '\\' };
            int spinnerIndex = 0;
            int totalCycles = durationInseconds * 4;

            for (int i = 0; i < totalCycles; i++)
            {
                Console.Write(spinnerChars[spinnerIndex]);
                System.Threading.Thread.Sleep(250);
                Console.Write("\b \b");
                spinnerIndex = (spinnerIndex + 1) % spinnerChars.Length;
            }
        }
    }
}