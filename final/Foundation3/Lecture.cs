public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string _speaker, int _capacity)
        : base(title, description, date, time, address)
    {
        this._speaker = _speaker;
        this._capacity = _capacity;

    }

    public string GetLectureFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}\n";
    }
}