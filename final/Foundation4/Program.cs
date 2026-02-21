using System;
using System.Collections.Generic;

namespace Program4_Exercise;

public class Program
{
    public static void Main()
    {
        var day = new DateTime(2022, 11, 3);
        var log = new List<Activity>
        {
            new Cycling(day, 45, 18.5),
            new Swimming(day, 40, 50),
            new Running(day, 30, 4.8)
        };

        var first = true;
        foreach (var item in log)
        {
            if (first) first = false;
            else Console.WriteLine();

            Console.WriteLine(item.GetSummary());
        }
    }
}
