using System;

public class BasicCounter : ICounter
{
    public BasicCounter(int count = 0)
    {
        Count = count;
    }

    public void Increment()
    {
        Count = Math.Min(MaxCount, Count + 1);
    }

    public int Count { get; private set; }
    
    // Add a property for MaxCount if it's not defined elsewhere in your code
    public int MaxCount { get; set; }
}

public interface ICounter
{
    void Increment();
    int Count { get; }
}
