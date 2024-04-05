using System;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>
        {
            new Video("GRWM for going on a Date", "MaryN", 10),
            new Video("Date Night Routine With Me", "NathalyMUA", 20),
            new Video("Strawberry MakeUp Tutorial", "gaby taylor", 19),
            new Video("how to have a Summer GLOW UP", "Jenn Leighton", 30)
        };

        // add the comments of the videos
        videos[0].AddComment("Looney", "current obsession!");
        videos[0].AddComment("lily1202", "I love your grwm! <3");
        videos[0].AddComment("serenaK", "I became a fan of your routines");

        videos[1].AddComment("alexanm","It was a trust the process on that foundation colour");
        videos[1].AddComment("Avandale", "Such an icon!");
        videos[1].AddComment("swiftaf", "She's glowing! Makeup really transforms her");

        videos[2].AddComment("gene12", "i love this type of videos, i want to start wearing makeup, help!");
        videos[2].AddComment("hannah00", "this makeup is so soft! loved the lipgloss shade");
        videos[2].AddComment("xiomi", "I love it so natural, specially for summertime");

        videos[3].AddComment("user20902", "I'm really OBSESSED with your makeup style!");
        videos[3].AddComment("sochi81", "My comfort YouTuber fr");
        videos[3].AddComment("rachelmnb2", "this is so helpful and love the energy");

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Lenght: {video._length} minutes");
            Console.WriteLine($"Number of comments: {video.GetNumberofComments()}");

            Console.WriteLine("Comments: ");
            foreach (var comment in video._comments)
            {
                Console.WriteLine($"-> {comment._commentatorName}: {comment._textComment}");
            }

            Console.WriteLine();
        }
    }
}