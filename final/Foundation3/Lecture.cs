public class Lecture : Event
{
    protected string _speaker;
    protected int _capacity;

    public Lecture(string title, string description, DateTime timeStamp, string address, string speaker, int capacity):base(title, description, timeStamp, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

        public string GetLectureEvent()
    {
        return $"Title: {_title} Description:  {_description} Time: {_timeStamp} Address: {_address} Speaker: {_speaker} Capacity: {_capacity}";
    }



}