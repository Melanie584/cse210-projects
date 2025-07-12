using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("How to be productive", "Jenn Cho", 800);
        var video2 = new Video("How to debug", "Alex Smith", 500);
        var video3 = new Video("Lets look into AI", "Jake and Lisa", 1100);

        video1.Comments.Add(new Comment("Emma", "I absolutly loved this video, Thanks!"));
        video1.Comments.Add(new Comment("James", "Thanks for the advice"));
        video1.Comments.Add(new Comment("Sarah", "Awesome thanks!"));

        video2.Comments.Add(new Comment("Daniel", "Been looking for a video like this thank you!"));
        video2.Comments.Add(new Comment("Olivia", "One of my favorites :)"));
        video2.Comments.Add(new Comment("Michael", "Will  definitely be sharing this with others!"));

        video3.Comments.Add(new Comment("Ethan", "Just to see how far technology has come, awesome"));
        video3.Comments.Add(new Comment("Hannah", "This is the reason why I do what I do Amazing!"));
        video3.Comments.Add(new Comment("Ryan", "Super cool!"));

        var videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.Comments.Count}");
            Console.WriteLine($"Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}