using System;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Mindfulness Activities:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an activity (1-4): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Mindfulness.Breathing breathingActivity = new Mindfulness.Breathing();
                breathingActivity.Perform();
            }
            else if (choice == "2")
            {
                Mindfulness.Reflection reflectionActivity = new Mindfulness.Reflection();
                reflectionActivity.Perform();
            }
            else if (choice == "3")
            {
                Mindfulness.Listing listingActivity = new Mindfulness.Listing();
                listingActivity.Perform();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting the program. Stay mindful!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select again.");
            }

            Console.WriteLine();
           


        }    
    }
}
