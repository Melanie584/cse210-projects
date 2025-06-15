using System;
using System.Collections.Generic;

namespace MindfulnessApp.Activities
{
    public class PromptRepository
    {
        private List<string> prompts = new List<string>()
        {
            "Think about a time you overcame a challenge.",
            "Recall a moment that made you feel grateful.",
            "Reflect on a personal strength you’ve shown recently.",
            "Consider a goal you want to achieve and why it matters.",
            "Think about someone who has positively influenced your life."
        };

        private Random random = new Random();

        public string GetRandomPrompt()
        {
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}