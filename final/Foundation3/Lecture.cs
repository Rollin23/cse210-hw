public class Lecture : Event
{
    protected string _speaker;
    protected int _capacity;

    public Lecture(string title, string description, DateTime timeStamp, string address, string speaker, int capacity):base(title, description, timeStamp, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }




}