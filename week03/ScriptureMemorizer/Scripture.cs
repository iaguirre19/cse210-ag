namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private static readonly Random s_random = new Random();

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            string[] wordsArray = text.Split(' ');
            foreach (string word in wordsArray)
            {
                Word newWord = new Word(word);
                _words.Add(newWord);
            }
        }

        public string GetDisplayText()
        {
            string result = "";
            
            result = result + _reference.GetReferenceString();
            result = result + " ";
            
            foreach (Word word in _words)
            {
                string wordText = word.ToString();
                result = result + wordText + " ";
            }

            result = result.Trim();
            return result;
        }

        public void HideRandomWords(int numberOfWordsToHide)
        {
            List<int> indicesOfVisibleWords = new List<int>();
            
            for (int index = 0; index < _words.Count; index = index + 1)
            {
                bool isHidden = IsWordHidden(index);
                if (isHidden == false)
                {
                    indicesOfVisibleWords.Add(index);
                }
            }

            int actualWordsToHide = numberOfWordsToHide;
            if (indicesOfVisibleWords.Count < numberOfWordsToHide)
            {
                actualWordsToHide = indicesOfVisibleWords.Count;
            }
            
            for (int counter = 0; counter < actualWordsToHide; counter = counter + 1)
            {
                int randomPosition = s_random.Next(indicesOfVisibleWords.Count);
                int wordIndexToHide = indicesOfVisibleWords[randomPosition];
                
                Word wordToHide = _words[wordIndexToHide];
                wordToHide.MarkAsHidden();
                wordToHide.Hide();
                
                indicesOfVisibleWords.RemoveAt(randomPosition);
            }
        }

        private bool IsWordHidden(int wordIndex)
        {
            Word word = _words[wordIndex];
            string wordText = word.ToString();
            
            if (wordText.Length == 0)
            {
                return false;
            }
            
            bool allCharactersAreUnderscores = true;
            
            foreach (char currentCharacter in wordText)
            {
                if (currentCharacter != '_')
                {
                    allCharactersAreUnderscores = false;
                    break;
                }
            }
            
            return allCharactersAreUnderscores;
        }

        public bool AreAllWordsHidden()
        {
            bool allHidden = true;
            
            for (int index = 0; index < _words.Count; index = index + 1)
            {
                bool isHidden = IsWordHidden(index);
                if (isHidden == false)
                {
                    allHidden = false;
                    break;
                }
            }
            
            return allHidden;
        }
    }
}
