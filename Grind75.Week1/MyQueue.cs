namespace Week1;

public class MyQueue
{
    private readonly Stack<int> _read;
    private readonly Stack<int> _write;
    
    public MyQueue()
    {
        _read = new Stack<int>();
        _write = new Stack<int>();
    }

    public void Push(int x)
    {
        _write.Push(x); 
    } 

    public int Pop() {
        if (!_read.Any()) {
            BuildReadStack();
        }

        return _read.Pop();
    }
    
    public int Peek()
    {
        if (!_read.Any()) {
            BuildReadStack();
        }

        return _read.Peek();
    }

    public bool Empty() => !(_write.Any() || _read.Any());

    private void BuildReadStack()
    {
        while (_write.Any())
        {
            _read.Push(_write.Pop());
        }
    }
}