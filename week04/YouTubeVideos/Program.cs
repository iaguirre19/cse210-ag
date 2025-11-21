using System;
using YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# Tutorial", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!", DateTime.Now.AddMinutes(-30)));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!", DateTime.Now.AddMinutes(-20)));

        Video video2 = new Video("Learn Python", "Jane Smith", 800);
        video2.AddComment(new Comment("Charlie", "Awesome content!", DateTime.Now.AddHours(-1)));
        video2.AddComment(new Comment("Dave", "I learned a lot.", DateTime.Now.AddHours(-2)));
        video2.AddComment(new Comment("Eve", "Can't wait for more videos.", DateTime.Now.AddHours(-3)));

        Video video3 = new Video("React Native Basics", "John Travolta", 1800);
        video3.AddComment(new Comment("Frank", "Great introduction! This video was very helpful.", DateTime.Now.AddMinutes(-15)));
        video3.AddComment(new Comment("Grace", "Looking forward to more advanced topics.", DateTime.Now.AddMinutes(-10)));
        video3.AddComment(new Comment("Heidi", "Can you make a video on state management?", DateTime.Now.AddMinutes(-5)));


        Video video4 = new Video("JavaScript Essentials", "Emily Blunt", 1200);
        video4.AddComment(new Comment("Ivan", "This was a fantastic overview of JavaScript essentials. Thanks!", DateTime.Now.AddMinutes(-25)));
        video4.AddComment(new Comment("Judy", "Very informative and well-explained.", DateTime.Now.AddMinutes(-30)));
        video4.AddComment(new Comment("Kevin", "Helped me understand the basics clearly.", DateTime.Now.AddMinutes(-35)));

        Console.WriteLine(video1.DisplayVideoInfo());
        Console.WriteLine();
        Console.WriteLine(video2.DisplayVideoInfo());
        Console.WriteLine();
        Console.WriteLine(video3.DisplayVideoInfo());
        Console.WriteLine();
        Console.WriteLine(video4.DisplayVideoInfo());
    }
}