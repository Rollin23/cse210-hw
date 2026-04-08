public class Lecture : Event
{
    protected string _speaker;
    protected int _capacity;

    public Lecture(string title, string description, string timeStamp, Address address, string eventType, string speaker, int capacity):base(title, description, timeStamp, address, eventType)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetLectureEvent()
    {
        return "Speaker: " + _speaker + "\nCapacity: " + _capacity + "\n";
    }



}