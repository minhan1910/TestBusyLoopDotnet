class BlockingQueue<T>
{
    private readonly List<T> _queue = [];

    public void Enqueue(T item)
    {
        _queue.Add(item);            
    }

    public bool IsEmpty()
    {
        return _queue.Count == 0;
    }

    public T Dequeue()
    {

        var item = _queue[0];
        _queue.RemoveAt(0);

        return item;
    }
}