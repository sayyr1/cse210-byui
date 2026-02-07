using System;

public class BreathingActivity : Activity
{
    private int _inhaleSeconds = 4;
    private int _exhaleSeconds = 6;

    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
          )
    { }

    protected override void RunCore()
    {
        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(_inhaleSeconds);
            Console.WriteLine();

            if (DateTime.Now >= end) break;

            Console.Write("Breathe out... ");
            ShowCountDown(_exhaleSeconds);
            Console.WriteLine();
        }
    }
}
