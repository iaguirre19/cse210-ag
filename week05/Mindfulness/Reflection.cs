namespace Mindfulness
{
    public class Reflection : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you overcame a challenge.",
            "Reflect on a moment when you felt truly at peace.",
            "Consider a situation where you helped someone in need.",
            "Recall a time when you learned something new about yourself."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn from this experience?",
            "How can you apply this lesson in your daily life?",
            "What positive feelings did you have during this experience?"
        };

        public Reflection() : base("Reflection Activity", "This activity will guide you through reflecting on meaningful experiences.")
        {
        }

        public void Perform()
        {
            Start();
            Random rand = new Random();
            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine("When you have something in mind, press Enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now, ponder on the following questions:");
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                string question = _questions[rand.Next(_questions.Count)];
                Console.WriteLine(question);
                PauseWithSpinner(6);
            }
            End();
        }
    }
}
