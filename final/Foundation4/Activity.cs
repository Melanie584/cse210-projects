public class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        this._date = date;
        this._lengthInMinutes = lengthInMinutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_lengthInMinutes} min) - " +
               $"Distance: {GetDistance():F2} miles, " +
               $"Speed: {GetSpeed(): F2} mph, " +
               $"Pace: {GetPace(): F2} min per mile";
    }
}