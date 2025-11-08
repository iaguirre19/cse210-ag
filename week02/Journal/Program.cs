using System;
using Journal;

class Program
{
    static void Main(string[] args)
    {
        JournalContainer journal = new JournalContainer();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine()?.Trim() ?? string.Empty;
            Console.WriteLine();

            if (choice == "1" || choice.ToLower() == "write")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                Console.Write("Answer here: ");
                string entryText = Console.ReadLine() ?? string.Empty;

                Entry entry = new Entry(DateTime.Now.ToString("MM/dd/yyyy"), prompt, entryText);
                journal.AddEntry(entry);
                Console.WriteLine("Entry added.\n");
            }
            else if (choice == "2" || choice.ToLower() == "display")
            {
                Console.WriteLine("Your journal entries:");
                journal.DisplayAllEntries();
            }
            else if (choice == "3" || choice.ToLower() == "load")
            {
                Console.Write("What is the filename?: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4" || choice.ToLower() == "save")
            {
                Console.Write("What is the filename?: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5" || choice.ToLower() == "quit" || choice.ToLower() == "exit")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1-5 or type the option.\n");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
