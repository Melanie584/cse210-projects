public class Job 
{
    public string _company;
    public string _jobTitle;
    public int _startYear = 1900, _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}");
    }
}
