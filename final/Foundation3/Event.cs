using System;
public class Event
{
    protected string _title;
    protected string _description;
    protected string _timeStamp;
    protected string _eventType;
    protected Address _address;

    public Event(string title, string description, string timeStamp, Address address, string eventType)
    {
        _title = title;
        _description = description;
        _timeStamp = timeStamp;
        _address = address;
        _eventType = eventType; 
    }

    public string GetStandardDetails()
    {
        return $"Title: " + _title + "\nDescription: " + _description + "\nDate: " + _timeStamp + "\nAddress: " + _address.GetAddress() + "\n";
    }
    
    public string GetFullDetails()
    {
        return $"\nTitle: " + _title + "\nEvent Type: " + _eventType + "\nDescription: " + _description + "\nTime: " + _timeStamp + "\nAddress:" + _address.GetAddress();
    }
    
    public string GetShortDetails()
    {
        return $"Title: " + _title + "\nType: " + _eventType + "\nDate: " + _timeStamp + "\n";
    }
}