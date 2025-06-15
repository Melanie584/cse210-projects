using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ListingPromptRepository
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        private Random _random = new Random();

        public string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}
