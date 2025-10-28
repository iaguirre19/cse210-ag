using System;

class Program
{
    static void Main(string[] args)
    {

        string symbolLetter;
        int percentage;

        Console.Write("Please wite your percentage: ");
        string userPercentage = Console.ReadLine();
        percentage = int.Parse(userPercentage);

        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        decimal percentageDecimal = Convert.ToDecimal(percentage);

        decimal lastDigit = percentageDecimal % 10;

        Console.WriteLine(lastDigit);


        if (lastDigit >= 7)
        {
            symbolLetter = "+";
        }
        else if (lastDigit < 3)
        {
            symbolLetter = "-";
        }
        else
        {
            symbolLetter = "";
        }

        Console.WriteLine($"Your grade is: {letter}{symbolLetter}");
        if(percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }



    }
}