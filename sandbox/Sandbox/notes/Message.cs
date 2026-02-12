public class Message
{
    public string _message;
    public int _priority;

    public string GetMessage()
    {
        return $"{_message}, {_priority} ";
    }
}