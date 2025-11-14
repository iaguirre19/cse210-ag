namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

       public void MarkAsHidden()
        {
            _isHidden = true;
        }

       public void Hide()
        {

            if (_isHidden)
            {
                if (_text.Length > 0)
                {

                    string hiddenWord = ""; 

                    foreach (char letter in _text)
                    {
                        hiddenWord += "_";
                    }


                    _text = hiddenWord;
                }
            }
        }


        public override string ToString()
        {
            return _text;
        }
        
    }
}