using System;
using ScriptureMemorizer;


 /*
  Exceeds requirements in this program:
  - ScriptureFactory: library of scriptures with random selection.
  - 'add' command: add scriptures at runtime and use the new one immediately.
  - Hide only visible words when selecting random words.
  - Input validation with TryParse to prevent crashes.
  - Shared static Random instances for consistent randomness.
 */

class Program
{
    static void Main(string[] args)
    {
        ScriptureFactory scriptureFactory = new ScriptureFactory();

        Scripture scripture = scriptureFactory.GetRandomScripture();

        string userInput = "";
        
        while (userInput != "quit" && scripture.AreAllWordsHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            Console.WriteLine("Type 'add' to add a new scripture.");
            
            userInput = Console.ReadLine();
            
            if (userInput == "quit")
            {
                break;
            }
            
            if (userInput == "")
            {
                scripture.HideRandomWords(3);
            }
            
            if (userInput == "add")
            {
                Console.Write("Enter the book name: ");
                string bookName = Console.ReadLine();

                int chapterNumber = 0;
                bool isValidChapter = false;
                while (isValidChapter == false)
                {
                    Console.Write("Enter the chapter number: ");
                    string chapterInput = Console.ReadLine();
                    bool canParse = int.TryParse(chapterInput, out chapterNumber);
                    if (canParse == true && chapterNumber > 0)
                    {
                        isValidChapter = true;
                        break;
                    }
                    Console.WriteLine("Please enter a valid positive integer.");
                }

                int startVerseNumber = 0;
                bool isValidStartVerse = false;
                while (isValidStartVerse == false)
                {
                    Console.Write("Enter the starting verse number: ");
                    string startVerseInput = Console.ReadLine();
                    bool canParse = int.TryParse(startVerseInput, out startVerseNumber);
                    if (canParse == true && startVerseNumber > 0)
                    {
                        isValidStartVerse = true;
                        break;
                    }
                    Console.WriteLine("Please enter a valid positive integer.");
                }

                Console.Write("Do you want to enter an ending verse number? (yes/no): ");
                string endVerseAnswer = Console.ReadLine();

                Reference newReference;
                
                if (endVerseAnswer != null && endVerseAnswer.ToLower() == "yes")
                {
                    int endVerseNumber = 0;
                    bool isValidEndVerse = false;
                    while (isValidEndVerse == false)
                    {
                        Console.Write("Enter the ending verse number: ");
                        string endVerseInput = Console.ReadLine();
                        bool canParse = int.TryParse(endVerseInput, out endVerseNumber);
                        if (canParse == true && endVerseNumber >= startVerseNumber)
                        {
                            isValidEndVerse = true;
                            break;
                        }
                        Console.WriteLine("Please enter a valid integer greater than or equal to the starting verse.");
                    }
                    newReference = new Reference(bookName, chapterNumber, startVerseNumber, endVerseNumber);
                }
                else
                {
                    newReference = new Reference(bookName, chapterNumber, startVerseNumber);
                }

                Console.Write("Enter the scripture text: ");
                string scriptureText = Console.ReadLine();

                Scripture newScripture = new Scripture(newReference, scriptureText);
                scriptureFactory.AddScripture(newScripture);

                scripture = newScripture;
            }
        }
        
        if (scripture.AreAllWordsHidden() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("All words are hidden. Program complete!");
        }
    }
}
