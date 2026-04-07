public class Reception : Event
{
    private string _rsvp;
    
    public Reception(string title, string description, DateTime timeStamp, string address, string speaker, int capacity, string rsvp):base(title, description, timeStamp, address)
    {
        _rsvp = rsvp;
    }
}