using System.IO;

namespace Journal
{
    public class JournalContainer
    {
        private List<Entry> _entries;

        public JournalContainer()
        {
            _entries = new List<Entry>();
        }

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void DisplayAllEntries()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("(No entries yet, please add some!)\n");
                return;
            }

            foreach (Entry entry in _entries)
            {
                entry.DisplayEntry();
                Console.WriteLine();
            }
        }

        public void SaveToFile(string filePath)
        {
            string extensionPath = Path.GetExtension(filePath);
            if (extensionPath != ".txt" || extensionPath == null)
            {
                Console.WriteLine("Please provide a .txt file.");
                return;
            }

            
            StreamWriter writer = new StreamWriter(filePath);

            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }

            writer.Close();
        }


        public void LoadFromFile(string filePath)
        {

            string extensionPath = Path.GetExtension(filePath);
            
            if (extensionPath != ".txt")
            {
                Console.WriteLine("Invalid file type. Please provide a .txt file.");
                return;
            }

            List<Entry> list = new List<Entry>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                string date = parts[0];
                string prompt = parts[1];
                string entryText = parts[2];

                Entry entry = new Entry(date, prompt, entryText);
                list.Add(entry);
            }

            _entries = list;
        }
    }
}
