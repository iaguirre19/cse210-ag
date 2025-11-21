namespace YouTubeVideos
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _lengthInSeconds;
        private List<Comment> _comments;


        public Video(string title, string author, int lengthInSeconds)
        {
            _title = title;
            _author = author;
            _lengthInSeconds = lengthInSeconds;
            _comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetCommentsCount()
        {
            int count = _comments.Count;
            return count;
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }

        public string DisplayVideoInfo()
        {
            return $"Title: {_title}, Author: {_author}, Length: {_lengthInSeconds} seconds, Comments: {GetCommentsCount()}" +
                   $"\nComments Details:\n" +
                   string.Join("\n", _comments.ConvertAll(c => c.DisplayComment()));
        }
    }
}