public class Outdoor : Event
{
    private string _weather;
    private Outdoor(string title, string description, DateTime timeStamp, string address, string speaker, int capacity, string weather):base(title, description, timeStamp, address)
    {
        _weather = weather;
    }
}