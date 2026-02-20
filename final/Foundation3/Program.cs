using System;

namespace Program3_Events;

public class Program
{
    public static void Main()
    {
        var a1 = new Address("500 College Ave", "Provo", "UT", "USA");
        var a2 = new Address("10 Harbour St", "Sydney", "NSW", "Australia");
        var a3 = new Address("1 Park Lane", "London", "Greater London", "United Kingdom");

        Event lecture = new Lecture(
            "Modern C# Patterns",
            "A practical talk on clean object-oriented design.",
            new DateTime(2026, 3, 12),
            "6:30 PM",
            a1,
            "Dr. Elena Carter",
            120
        );

        Event reception = new Reception(
            "Spring Mixer Night",
            "Meet new people, enjoy snacks, and network.",
            new DateTime(2026, 4, 5),
            "7:00 PM",
            a2,
            "rsvp@events-example.com"
        );

        Event outdoor = new OutdoorGathering(
            "City Picnic",
            "Bring a blanket and something to share.",
            new DateTime(2026, 5, 20),
            "12:00 PM",
            a3,
            "Light breeze, partly cloudy"
        );

        PrintEvent(lecture);
        Console.WriteLine(new string('-', 45));
        PrintEvent(reception);
        Console.WriteLine(new string('-', 45));
        PrintEvent(outdoor);
    }

    private static void PrintEvent(Event e)
    {
        Console.WriteLine("STANDARD DETAILS");
        Console.WriteLine(e.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("FULL DETAILS");
        Console.WriteLine(e.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("SHORT DESCRIPTION");
        Console.WriteLine(e.GetShortDescription());
    }
}