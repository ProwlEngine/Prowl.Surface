using System;


namespace Prowl.Surface;


// from https://stackoverflow.com/a/5924776
internal class CircularBuffer<T>
{
    private readonly int _size;
    private readonly object _lock;

    private int _count;
    private int _head;
    private int _tail;
    private T[] _values;


    public CircularBuffer(int max)
    {
        _size = max;
        _lock = new();
        _count = 0;
        _head = 0;
        _tail = 0;
        _values = new T[_size];
    }


    static int Incr(int index, int size)
    {
        return (index + 1) % size;
    }


    public int Size => _size;
    public int Count => _count;


    public void Enqueue(T obj)
    {
        lock (_lock)
        {
            UnsafeEnqueue(obj);
        }
    }


    public void UnsafeEnqueue(T obj)
    {
        _values[_tail] = obj;

        if (Count == Size)
            _head = Incr(_head, Size);

        _tail = Incr(_tail, Size);
        _count = Math.Min(_count + 1, Size);
    }


    public bool TryDequeue(out T value)
    {
        lock (_lock)
        {
            return UnsafeTryDequeue(out value);
        }
    }


    public bool UnsafeTryDequeue(out T value)
    {
        if (_count == 0)
        {
            value = default;
            return false;
        }

        value = _values[_head];
        _values[_head] = default;
        _head = Incr(_head, Size);
        _count--;

        return true;
    }
}
