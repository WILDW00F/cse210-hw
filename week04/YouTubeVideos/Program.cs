using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video(
            "Top 10 RPG Games of 2026",
            "GameSpot",
            780);

        video1.AddComment(new Comment("Alex", "Great list!"));
        video1.AddComment(new Comment("Jordan", "I can't believe Elden Ring wasn't included."));
        video1.AddComment(new Comment("Sarah", "Awesome recommendations."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video(
            "Learn C# in 30 Minutes",
            "Programming Hub",
            1800);

        video2.AddComment(new Comment("Chris", "Very easy to follow."));
        video2.AddComment(new Comment("Emily", "This helped me finish my homework."));
        video2.AddComment(new Comment("Kevin", "Can you make an advanced version?"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video(
            "How to Build a Gaming PC",
            "Tech Builders",
            1450);

        video3.AddComment(new Comment("Nathan", "Super informative."));
        video3.AddComment(new Comment("Olivia", "Thanks for explaining every part."));
        video3.AddComment(new Comment("Mia", "Built my first PC because of this."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video(
            "Relaxing Piano Music",
            "Peaceful Sounds",
            3600);

        video4.AddComment(new Comment("James", "Perfect for studying."));
        video4.AddComment(new Comment("Sophia", "Very calming."));
        video4.AddComment(new Comment("Daniel", "I've had this on repeat all day."));
        videos.Add(video4);

        // Display Videos
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");
            Console.WriteLine();

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}:");
                Console.WriteLine($"  {comment.GetCommentText()}");
                Console.WriteLine();
            }
        }
    }
}