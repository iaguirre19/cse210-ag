namespace YouTubeVideos
{
    public class Comment
    {
        private string _author;
        private string _text;
        private DateTime _timestamp;

        public Comment(string author, string text, DateTime timestamp)
        {
            if(string.IsNullOrWhiteSpace(author))
            {
                _author = "Unknown";
            }
            else
            {
                _author = author;
            }
            _text = text;
            _timestamp = timestamp;
        }


        public string DisplayComment()
        {
            return $"{_author}: {_text} (Posted on {_timestamp})";
        }
    }
}