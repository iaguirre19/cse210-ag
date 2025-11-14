
namespace ScriptureMemorizer
{
    public class ScriptureFactory
    {
        private List<Scripture> scriptures;
        private static readonly Random s_random = new Random();

        public ScriptureFactory()
        {
            scriptures = new List<Scripture>
            {
                new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
                new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want."),
                new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
                new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
                new Scripture(new Reference("Romans", 8, 28), "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."),
                new Scripture(new Reference("Proverbs", 3, 5, 6),"Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +"In all thy ways acknowledge him, and he shall direct thy paths."),
                new Scripture(new Reference("2 Nephi", 31, 19, 20),"And now, my beloved brethren, after ye have gotten into this strait and narrow path, I would ask if all is done? " +"Behold, I say unto you, Nay; for ye have not come thus far save it were by the word of Christ with unshaken faith in him, relying wholly upon the merits of him who is mighty to save. " +"Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. " +"Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life."),
            };
        }

        public Scripture GetRandomScripture()
        {
            int index = s_random.Next(scriptures.Count);
            return scriptures[index];
        }

        public void AddScripture(Scripture scripture)
        {
            scriptures.Add(scripture);
        }
    }
}
