var queue = new BlockingQueue<string>();
var t1 = new Thread(DeQueueThread) { IsBackground = true };
t1.Start();

string? s = null;

do
{
    Console.Write("S: ");
    s = Console.ReadLine();
    if (!string.IsNullOrEmpty(s))
    {
        queue.Enqueue(s);
    }
    Thread.Sleep(100);
} while (!string.IsNullOrEmpty(s));

void DeQueueThread()
{
    while (true)
    {
        while (queue.IsEmpty() == false)
        {
            var item = queue.Dequeue();
            Console.WriteLine($"Q: {item}");
        }
    }
}