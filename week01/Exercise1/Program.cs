// For this exercise I try to validate that the user does not enter empty names, using a do-while loop.
using System;
class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;

        do
        {
            Console.Write("What is your first name? ");
            firstName = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("First name cannot be empty. Please try again.");
            }
        } while (string.IsNullOrWhiteSpace(firstName));

        do
        {
            Console.Write("What is your last name? ");
            lastName = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("Last name cannot be empty. Please try again.");
            }
        } while (string.IsNullOrWhiteSpace(lastName));

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}