using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;
        int sum = 0;
        int largest = 0;


        do
        {
            Console.Write("Enter a number (or type '0' to finish): ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);


        if(numbers.Count > 0)
        {
            
        foreach (int number in numbers)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }



        }
        double average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average:F2}"); // Formato con 2 decimales
            Console.WriteLine($"The largest number is: {largest}");
        } else
        {
            Console.WriteLine("Not numbers entered");
        }

    }
}