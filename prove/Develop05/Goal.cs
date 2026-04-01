public class Goal
{
    protected int _points;
    protected string _name;
    

    public Goal(string name)
    {
        _name = name;
    }

    public virtual void PrintDetails()
    {
        
    }

    public int GetScore()
    {
         return _points;
    }

    public virtual int AddPoints(int amount)
    {
        _score = _points + amount;
    }


}