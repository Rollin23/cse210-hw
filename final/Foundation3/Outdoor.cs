public class Outdoor : Event
{
    protected string _weather;
    public Outdoor(string title, string description, string timeStamp, Address address, string eventType, string weather):base(title, description, timeStamp, address, eventType)
    {
        _weather = weather;
    }

    public string GetOutdoorEvent()
    {
        return $"Weather: " + _weather + "\n";
    }
}