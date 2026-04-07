public class Outdoor : Event
{
    private string _weather;
    private Outdoor(string title, string description, DateTime timeStamp, string address, string speaker, int capacity, string weather):base(title, description, timeStamp, address)
    {
        _weather = weather;
    }

        public string GetOutdoorEvent()
    {
        return $"Title: {_title} Description:  {_description} Time: {_timeStamp} Address: {_address} Weather: {_weather} ";
    }
}