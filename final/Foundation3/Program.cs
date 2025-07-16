using System;

class Program
{
    static void Main(string[] args)
    {
        Address outdoorAddress = new Address("123 Park Blvd", "Los Angeles", "CA", "USA");
        OutdoorGathering outdoor = new OutdoorGathering(
            "Picnic in the park",
            "Bring your family for a fun picnic",
            "2025-09-12",
            "12:00 PM",
            outdoorAddress,
            "sunny"
        );

        Console.WriteLine("== Standard Details ==");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("== Full Details ==");
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("== Short Description ==");
        Console.WriteLine(outdoor.GetShortDescription());
        Console.WriteLine();
    }
}