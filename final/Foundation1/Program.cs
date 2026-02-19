using System;
using System.Collections.Generic;

namespace Program1_Videos;

public class Program
{
    public static void Main()
    {
        var videos = new List<Video>();

        var v1 = new Video("C# Basics in 10 Minutes", "Nina", 612);
        v1.AddComment(new Comment("Mateo", "This finally clicked for me."));
        v1.AddComment(new Comment("Sara", "Clean explanation, thanks!"));
        v1.AddComment(new Comment("Ken", "Can you do a part 2 on classes?"));
        videos.Add(v1);

        var v2 = new Video("Unity 2D Movement", "Alex", 845);
        v2.AddComment(new Comment("Lina", "The input smoothing tip was gold."));
        v2.AddComment(new Comment("Jon", "Works great with Rigidbody2D."));
        videos.Add(v2);

        var v3 = new Video("Debugging Like a Pro", "Rami", 503);
        v3.AddComment(new Comment("Dani", "Breakpoints changed my life."));
        v3.AddComment(new Comment("Ivy", "Loved the step-by-step approach."));
        v3.AddComment(new Comment("Omar", "More examples please."));
        videos.Add(v3);

        foreach (var v in videos)
        {
            Console.WriteLine(v.GetDisplayText());
            Console.WriteLine(new string('-', 40));
        }
    }
}
