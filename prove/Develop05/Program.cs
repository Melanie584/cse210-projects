using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;

    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine($"\nTotal Score: {totalPoints}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordGoal(); break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type: 1=Simple, 2=Eternal, 3=Checklist");
        string type = Console.ReadLine();
        Console.Write("Name: "); string name = Console.ReadLine();
        Console.Write("Description: "); string desc = Console.ReadLine();
        Console.Write("Points: "); int pts = int.Parse(Console.ReadLine());

        if (type == "1")
            goals.Add(new SimpleGoal(name, desc, pts));
        else if (type == "2")
            goals.Add(new EternalGoal(name, desc, pts));
        else if (type == "3")
        {
            Console.Write("Target count: "); int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: "); int bonus = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, desc, pts, target, bonus));
        }
    }

    static void ListGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");
        }
    }

    static void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string file = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(totalPoints);
            foreach (var goal in goals)
            {
                sw.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    static void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string file = Console.ReadLine();
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            totalPoints = int.Parse(lines[0]);
            goals.Clear();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                if (type == "SimpleGoal")
                    goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                else if (type == "EternalGoal")
                    goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                else if (type == "ChecklistGoal")
                {
                    var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                                 int.Parse(parts[5]), int.Parse(parts[4]));

                    int completed = int.Parse(parts[6]);
                    for (int j = 0; j < completed; j++)
                        goal.RecordEvent(); 
                    goals.Add(goal);
                }
            }
        }
    }

static void RecordGoal()
    {
        ListGoals();
        Console.Write("Enter goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n🌟 You selected:");
        Console.ResetColor();
        Console.WriteLine(goals[index].GetDetails());

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n🎯 Recording goal event...");
        Console.ResetColor();

        goals[index].RecordEvent();
        totalPoints += goals[index].Points;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n🏆 Total Score is now: {totalPoints}\n");
        Console.ResetColor();
    }

}