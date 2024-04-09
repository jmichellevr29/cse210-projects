using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Event lecture = new Lecture("Blood Biomarkers", "Introduction to blood biomarkers and its relevance in cancer diagnosis", new DateTime(2024, 4, 22), new TimeSpan(15, 0, 0), "American St.", "Dr.Elena Taylor", 100);
        Event reception = new Reception("Star Wars Gathering", "Lets celebrate together Star Wars Day !", new DateTime(2024, 5, 4), new TimeSpan (17, 0, 0), "431 Elm St", "rsvp@emailsample.com");
        Event outdoorGathering = new OutdoorGatherings("Listening Picnic", "A picnic to share and listen your favorite CD's and make new friends", new DateTime(2024, 5, 12), new TimeSpan(15, 0, 0), "Rosa Ave", "Sunny and Warm");

        // full details 
        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetAllDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetAllDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoorGathering.GetAllDetails());
        Console.WriteLine();

        // short descriptions 
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}