class BlockingQueue
{
    private readonly List<string> _queue = [];

    public void Enqueue(string item)
    {
        _queue.Add(item);            
    }

    public bool IsEmpty()
    {
        return _queue.Count == 0;
    }

    public string Dequeue()
    {

        var item = _queue[0];
        _queue.RemoveAt(0);

        return item;
    }
}