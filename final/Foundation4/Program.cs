using System;

class Program
{
    static void Main(string[] args)
    {
        Activity testActivity = new Activity("03 Nov 2022", 30);

        Console.WriteLine();
        Console.WriteLine(testActivity.GetSummary());
    }
}