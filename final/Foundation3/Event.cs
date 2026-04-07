using System;
public class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _timeStamp;
    private string _eventType;
    protected string _address;

    public Event(string title, string description, DateTime timeStamp, string address)
    {
        _title = title;
        _description = description;
        _timeStamp = timeStamp;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title} Description:  {_description} Date: {_timeStamp} Address: {_address} ";
    }
    
    public string GetSFullDetails()
    {
        return $"Title: {_title} Description:  {_description} Time: {_timeStamp} Address: {_address} Event Type: ";
    }
    
    public string GetShortDetails()
    {
        return $"Title: {_title} Type: {_eventType} Date: {_timeStamp}";
    }
}