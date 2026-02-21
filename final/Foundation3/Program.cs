using System;
using System.Collections.Generic;

namespace Program3_Events;

public class Program
{
    public static void Main()
    {
        var ut = new Address("500 College Ave", "Provo", "UT", "USA");
        var nsw = new Address("10 Harbour St", "Sydney", "NSW", "Australia");
        var uk = new Address("1 Park Lane", "London", "Greater London", "United Kingdom");

        var events = new List<Event>
        {
            new Reception(
                "Spring Mixer Night",
                "Meet new people, enjoy snacks, and network.",
                new DateTime(2026, 4, 5),
                "7:00 PM",
                nsw,
                "rsvp@egmail.com"
            ),
            new Lecture(
                "Modern Python",
                "A practical talk on clean object-oriented design.",
                new DateTime(2026, 3, 12),
                "6:30 PM",
                ut,
                "Dr. Elena Carter",
                120
            ),
            new OutdoorGathering(
                "Otavalo Picnic",
                "Bring a blanket and something to share.",
                new DateTime(2026, 5, 20),
                "12:00 PM",
                uk,
                "Light breeze, partly cloudy"
            )
        };

        for (var i = 0; i < events.Count; i++)
        {
            PrintEvent(events[i]);
            if (i < events.Count - 1) Console.WriteLine(new string('-', 45));
        }
    }

    private static void PrintEvent(Event ev)
    {
        Console.WriteLine("STANDARD DETAILS");
        Console.WriteLine(ev.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("FULL DETAILS");
        Console.WriteLine(ev.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("SHORT DESCRIPTION");
        Console.WriteLine(ev.GetShortDescription());
    }
}
