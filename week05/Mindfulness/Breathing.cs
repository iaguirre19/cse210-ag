namespace Mindfulness
{
    public class Breathing : Activity
    {
        public Breathing() : base("Breathing Exercise", "This activity will help you relax by guiding you through deep breathing.")
        {
        }

        public void Perform()
        {
            Start();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                int remaining = Math.Max(0, (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds));
                int inhaleSeconds = Math.Min(4, remaining);
                if (inhaleSeconds > 0)
                {
                    Countdown(inhaleSeconds);
                }

                remaining = Math.Max(0, (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds));
                if (remaining <= 0)
                {
                    break;
                }

                Console.WriteLine("Breathe out...");
                int exhaleSeconds = Math.Min(6, remaining);
                Countdown(exhaleSeconds);
            }

            End();
        }
    }
}
