using System;

class Program
{
    static void Main(string[] args)
    {
        Address receptionAddress = new Address("200 Main St", "Chicago", "IL", "USA");
        Reception reception = new Reception(
            "Networking Night",
            "Meet professionals from various industries",
            "06-01-2025",
            "6:00 PM",
            receptionAddress,
            "rsvp@example.com"
        );

        Address outdoorAddress = new Address("123 Park Blvd", "Los Angeles", "CA", "USA");
        OutdoorGathering outdoor = new OutdoorGathering(
            "Picnic in the park",
            "Bring your family for a fun picnic",
            "09-12-2025",
            "12:00 PM",
            outdoorAddress,
            "sunny"
        );

        Address lectureAddress = new Address("400 University Ave", "New York", "NY", "USA");
        Lecture lecture = new Lecture(
            "Intro to C#",
            "Learn the basics of C# and OOP",
            "07-16-2025",
            "10:00 AM",
            lectureAddress,
            "Professor Jane Doe",
            100
        );

        Console.WriteLine("== Standard Details ==");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("== Full Details ==");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("== Short Description ==");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("\n---------------------\n");



        Console.WriteLine("== Standard Details ==");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("== Full Details ==");
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("== Short Description ==");
        Console.WriteLine(outdoor.GetShortDescription());
        Console.WriteLine("\n---------------------\n");



        Console.WriteLine("== Standard Details ==");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("== Full Details ==");
        Console.WriteLine(lecture.GetLectureFullDetails());
        Console.WriteLine();

        Console.WriteLine("== Short Description ==");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("\n---------------------\n");
    }
}