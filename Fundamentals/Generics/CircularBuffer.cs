using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Generics
{
    public interface IBuffer<T>
    {
        bool IsEmpty { get; }

        T Read();
        void Write(T element);
    }
    public class CircularBuffer<T> : IBuffer<T>
    {
        private T[] _buffer;
        private int _start = 0;
        private int _end = 0;

        public CircularBuffer() : this(capacity: 3)
        {
        }

        public CircularBuffer(int capacity)
        {
            _buffer = new T[capacity + 1];
        }

        public bool IsFull
        {
            get { return IncrementPosition(_end) == _start; }
        }

        public bool IsEmpty
        {
            get { return _start == _end; }
        }

        public void Write(T element)
        {
            _buffer[_end] = element;
            _end = IncrementPosition(_end);

            if (_end == _start)
            {
                _start = IncrementPosition(_start);
            }
        }

        public T Read()
        {
            var result = _buffer[_start];
            _start = IncrementPosition(_start);

            return result;
        }

        private int IncrementPosition(int position) => (position + 1) % _buffer.Length;
    }
}
