public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue regardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    public string Dequeue()
    {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the index of the item with the highest priority to remove
        var highPriorityIndex = 0;
        // start the search at the front of the list.
        // ref:  TestPriorityQueue_Dequeue_Equal_Pri test case
        //for (int index = 1; index < _queue.Count - 1; index++)
        // finesh the search at the back of the list.
        // ref:  TestPriorityQueue_Dequeue_Mixed_Pri test case
        //for (int index = 0; index < _queue.Count - 1; index++)
        for (int index = 0; index < _queue.Count; index++)
        {
            // only move the index if the priority is greater in order to find the earliest instance of the highest priority
            // ref:  TestPriorityQueue_Dequeue_Equal_Pri test case
            //if (_queue[index].Priority >= _queue[highPriorityIndex].Priority)
            if (_queue[index].Priority > _queue[highPriorityIndex].Priority)
                highPriorityIndex = index;
        }

        // Remove and return the item with the highest priority
        var value = _queue[highPriorityIndex].Value;
        // changed to remove the item as well
        // ref:  TestPriorityQueue_Dequeue_Equal_Pri test case
        _queue.RemoveAt(highPriorityIndex);
        return value;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}