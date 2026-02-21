using System;
using System.Collections.Generic;

namespace Program1_Videos;

public class Program
{
    public static void Main()
    {
        var videos = new List<Video>
        {
            MakeVideo(
                "Unity 2D Movement",
                "Alex",
                845,
                new Comment("Lina", "The input smoothing tip was gold."),
                new Comment("Jon", "Works great with Rigidbody2D."),
                new Comment("Mia", "Could you also cover jumping and dashing?")
            ),
            MakeVideo(
                "New big",
                "Nina",
                612,
                new Comment("Mateo", "This finally clicked for me."),
                new Comment("Sara", "Clean explanation, thanks!"),
                new Comment("Ken", "Can you do a part 2 on classes?")
            ),
            MakeVideo(
                "Debugging Like a Pro",
                "Rami",
                503,
                new Comment("Dani", "Breakpoints changed my life."),
                new Comment("Ivy", "Loved the step-by-step approach."),
                new Comment("Omar", "More examples please.")
            )
        };

        foreach (var vid in videos)
        {
            Console.WriteLine(vid.GetDisplayText());
            Console.WriteLine(new string('-', 40));
        }
    }

    private static Video MakeVideo(string title, string by, int secs, params Comment[] notes)
    {
        var v = new Video(title, by, secs);
        foreach (var note in notes) v.AddComment(note);
        return v;
    }
}
