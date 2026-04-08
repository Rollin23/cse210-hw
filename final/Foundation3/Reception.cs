public class Reception : Event
{
    private string _rsvp;
    
    public Reception(string title, string description, string timeStamp, Address address, string eventType, string rsvp):base(title, description, timeStamp, address, eventType)
    {
        _rsvp = rsvp;
    }

        public string GetReceptionEvent()
    {
        return "RSVP: " +_rsvp + "\n";
    }
}