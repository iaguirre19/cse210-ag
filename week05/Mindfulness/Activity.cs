using System;
using System.Threading;

namespace Mindfulness
{
    public class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void Start()
        {
            Console.WriteLine($"Welcome to the {_name}.");
            Console.WriteLine(_description);
            SetDuration();
            Console.WriteLine("Get ready to begin...");
            PauseWithSpinner(3);
        }

        protected void SetDuration()
        {
            Console.Write("Enter the duration in seconds: ");
            while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
            {
                Console.Write("Please enter a valid positive number of seconds: ");
            }
        }

        protected void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        protected void PauseWithSpinner(int seconds)
        {
            char[] spinner = { '|', '/', '-', '\\' };
            DateTime end = DateTime.Now.AddSeconds(seconds);
            int index = 0;
            while (DateTime.Now < end)
            {
                Console.Write($"\r{spinner[index % spinner.Length]}");
                Thread.Sleep(250);
                index++;
            }
            Console.Write("\r \r");
        }

        public void End()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            PauseWithSpinner(2);
            Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
            PauseWithSpinner(3);
        }
    }
}
