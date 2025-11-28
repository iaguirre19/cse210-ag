namespace Mindfulness
{
    public class Listing: Activity
    {
        private List<string> _prompts = new List<string>
        {
            "List as many things as you can that you are grateful for.",
            "List the people who have positively impacted your life.",
            "List the personal strengths you possess.",
            "List the activities that bring you joy."
        };

        public Listing() : base("Listing Activity", "This activity will help you reflect on the positive aspects of your life by listing them.")
        {
        }

        public void Perform()
        {
            Start();
            Random rand = new Random();
            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine("You have a few seconds to prepare...");
            Countdown(5);
            Console.WriteLine("List as many items as you can before time runs out. Start listing now:");

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            List<string> responses = new List<string>();

            while (DateTime.Now < endTime)
            {
                string response = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(response))
                {
                    responses.Add(response);
                }
            }

            Console.WriteLine($"You listed {responses.Count} items. Well done!");
            End();
        }
    }
}
