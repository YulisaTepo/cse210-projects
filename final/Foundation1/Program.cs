using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Console.WriteLine("YouTube Program");
        Comment comment1 = new Comment("Lury", "That looks incredible!");
        Comment comment2 = new Comment("Lesly", "I loved it!");
        Comment comment3 = new Comment("Suxe", "That's simpler than I thought. I'll do one right now.");
        Comment comment4 = new Comment("User123", "Great explanation, thanks for the video!");
        Comment comment5 = new Comment("Karol_05", "I have visited that place as well, just amazing :)");
        Comment comment6 = new Comment("Kally", "Where is that? I would love to go there.");
        Comment comment7 = new Comment("Steven", "Such a nice family, you seems so happy, I'm so happy for you ^^.");
        Comment comment8 = new Comment("Gloria", "Congrats!");
        Comment comment9 = new Comment("Treice", "Do your best!");
        Comment comment10 = new Comment("Annie", "We now you can do this!");
        Comment comment11 = new Comment("Kevin", "Great opportunity! You'll learn a lot there, trust me.");
        Comment comment12 = new Comment("Mike", "That's a good company. I hope all goes well for you. ");

        Video video1 = new Video("Basic bag (Tuturial)", "Fashion Channel", 300);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);
        videos.Add(video1);
        Video video2 = new Video("Family trip", "BigFamily", 480);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        videos.Add(video2);
        Video video3 = new Video("Announcement!! New job?", "Hanna's Vlog", 800);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);
        video3.AddComment(comment11);
        video3.AddComment(comment12);
        videos.Add(video3);
        foreach (Video video in videos)
        {
            Console.WriteLine("________________________________________________________________________________________");
            Console.WriteLine("\nVIDEO");
            Console.WriteLine(video.toString());
            Console.WriteLine("\nCOMMENTS");
            Console.WriteLine(video.GetCommentList());
        }
    }
}