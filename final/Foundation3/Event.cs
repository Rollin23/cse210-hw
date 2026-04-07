using System;

public class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _timeStamp;

    protected string _address;

    public Event(string title, string description, DateTime timeStamp, string address)
    {
        _title = title;
        _description = description;
        _timeStamp = timeStamp;
        _address = address;

    }
}