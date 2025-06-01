
using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Goal> goals = new List<Goal>();
            int score = 0;

            while (true)
            {
                Console.WriteLine("\nEternal Quest Program");
                Console.WriteLine("1. Create a new goal");
                Console.WriteLine("2. Record an event");
                Console.WriteLine("3. Display goals");
                Console.WriteLine("4. Display score");
                Console.WriteLine("5. Save goals");
                Console.WriteLine("6. Load goals");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal(goals);
                        break;
                    case "2":
                        score += RecordEvent(goals);
                        break;
                    case "3":
                        DisplayGoals(goals);
                        break;
                    case "4":
                        Console.WriteLine($"Current score: {score}");
                        break;
                    case "5":
                        SaveGoals(goals, score);
                        break;
                    case "6":
                        score = LoadGoals(goals);
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void CreateGoal(List<Goal> goals)
        {
            Console.WriteLine("Choose goal type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            string choice = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter goal points: ");
            int points = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("Enter target count: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                    break;
                default:
                    Console.WriteLine("Invalid goal type. Please try again.");
                    break;
            }
        }

        static int RecordEvent(List<Goal> goals)
        {
            Console.WriteLine("Choose a goal to record:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].Name}");
            }

            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= goals.Count)
            {
                return goals[choice - 1].RecordEvent();
            }
            else
            {
                Console.WriteLine("Invalid choice. No points awarded.");
                return 0;
            }
        }

        static void DisplayGoals(List<Goal> goals)
        {
            foreach (var goal in goals)
            {
                Console.WriteLine(goal);
            }
        }

        static void SaveGoals(List<Goal> goals, int score)
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                writer.WriteLine(score);
                foreach (var goal in goals)
                {
                    writer.WriteLine(goal.ToFileString());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }

        static int LoadGoals(List<Goal> goals)
        {
            goals.Clear();
            int score = 0;

            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    switch (type)
                    {
                        case "SimpleGoal":
                            goals.Add(new SimpleGoal(name, description, points));
                            break;
                        case "EternalGoal":
                            goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "ChecklistGoal":
                            int targetCount = int.Parse(parts[4]);
                            int bonusPoints = int.Parse(parts[5]);
                            int currentCount = int.Parse(parts[6]);
                            goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints, currentCount));
                            break;
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully.");
            return score;
        }
    }
}
