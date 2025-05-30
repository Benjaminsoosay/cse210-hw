
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Exploring the Amazon Rainforest", "NatureWorld", 540);
        video1.AddComment(new Comment("Alice", "This was so informative!"));
        video1.AddComment(new Comment("Bob", "Amazing visuals."));
        video1.AddComment(new Comment("Charlie", "Loved the narration."));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Coding Tips", "CodeMaster", 300);
        video2.AddComment(new Comment("Dave", "Tip #4 changed my life."));
        video2.AddComment(new Comment("Eve", "Very helpful, thanks!"));
        video2.AddComment(new Comment("Frank", "Subscribed!"));
        videos.Add(video2);

        Video video3 = new Video("History of the Roman Empire", "HistoryHub", 720);
        video3.AddComment(new Comment("Grace", "Great summary."));
        video3.AddComment(new Comment("Heidi", "I learned a lot."));
        video3.AddComment(new Comment("Ivan", "Well explained."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
