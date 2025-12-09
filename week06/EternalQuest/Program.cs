using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _score = 0;

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine() ?? string.Empty;
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("What type of goal do you want to create?");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Choose 1, 2 or 3: ");

        string typeChoice = Console.ReadLine() ?? string.Empty;

        string name = PromptForString("Goal name: ");
        string description = PromptForString("Description: ");
        int points = PromptForInt("Points for completion: ");

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                int target = PromptForInt("How many times to complete?: ");
                int bonus = PromptForInt("Bonus points: ");
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid type. Goal not created.");
                return;
        }

        Console.WriteLine("Goal created.");
    }

    private static void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayText()}");
        }
    }

    private static void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("Create a goal first.");
            return;
        }

        ListGoals();
        int index = PromptForInt("Which goal did you accomplish? (enter the number): ") - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        Goal goal = _goals[index];
        int earned = goal.RecordEvent();
        _score += earned;
        Console.WriteLine($"You earned {earned} points. Total score: {_score}.");
    }

    private static void SaveGoals()
    {
        string filename = PromptForString("Filename to save (e.g. goals.txt): ");

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetSaveString());
                }
            }

            Console.WriteLine("Goals saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving: {ex.Message}");
        }
    }

    private static void LoadGoals()
    {
        string filename = PromptForString("Filename to load: ");

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(filename);
            List<Goal> loadedGoals = new List<Goal>();

            if (lines.Length == 0)
            {
                Console.WriteLine("File is empty.");
                return;
            }

            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                Goal goal = ParseGoalLine(lines[i]);
                if (goal != null)
                {
                    loadedGoals.Add(goal);
                }
            }

            _goals = loadedGoals;
            Console.WriteLine("Goals loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading: {ex.Message}");
        }
    }

    private static Goal ParseGoalLine(string line)
    {
        string[] parts = line.Split(':');
        if (parts.Length != 2)
        {
            return null;
        }

        string type = parts[0];
        string[] data = parts[1].Split('|');

        try
        {
            switch (type)
            {
                case "SimpleGoal":
                    return new SimpleGoal(
                        data[0],
                        data[1],
                        int.Parse(data[2]),
                        bool.Parse(data[3]));
                case "EternalGoal":
                    return new EternalGoal(
                        data[0],
                        data[1],
                        int.Parse(data[2]));
                case "ChecklistGoal":
                    return new ChecklistGoal(
                        data[0],
                        data[1],
                        int.Parse(data[2]),
                        int.Parse(data[3]),
                        int.Parse(data[4]),
                        int.Parse(data[5]));
                default:
                    return null;
            }
        }
        catch
        {
            return null;
        }
    }

    private static string PromptForString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? string.Empty;
    }

    private static int PromptForInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? "0";

            if (int.TryParse(input, out int value))
            {
                return value;
            }

            Console.WriteLine("Please enter a valid number.");
        }
    }
}
