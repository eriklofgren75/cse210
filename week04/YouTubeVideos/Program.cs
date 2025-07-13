using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Spanish Lesson of the Week", "Spanish School", 380);
        video1.AddComment(new Comment("Michael", "Thanks, this will help for our trip"));
        video1.AddComment(new Comment("Jennifer", "Muchas gracias"));
        video1.AddComment(new Comment("Maria", "WOW so cool!"));
        videos.Add(video1);

        Video video2 = new Video("Freeze Dry Everything", "Cooking With Kevin", 400);
        video2.AddComment(new Comment("Tyler", "Who knew grapes would do that!"));
        video2.AddComment(new Comment("Frank", "WOW!"));
        video2.AddComment(new Comment("Timmy", "Could you try watermelon next?"));
        videos.Add(video2);

        Video video3 = new Video("Top 10 Funny Dogs", "Top 10 Productions", 550);
        video3.AddComment(new Comment("Helen", "HAHA"));
        video3.AddComment(new Comment("Megan", "Number 6 was the best!"));
        video3.AddComment(new Comment("Trevor", "I don't know if number 3 was funny."));
        video3.AddComment(new Comment("Matt", "Trevor is wrong. Number 3 was the best."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Video Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length of Video is: {video.GetLength()} seconds");
            Console.WriteLine($"Total Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}