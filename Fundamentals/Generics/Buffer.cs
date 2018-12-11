using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Generics
{
    class Buffer<T> : IBuffer<T>
    {
        Queue<T> _queue = new Queue<T>();
        public bool IsEmpty
        {
            get { return _queue.Count == 0; }
        }
        public void Write(T element)
        {
            _queue.Enqueue(element);
        }

        public T Read()
        {
            return _queue.Dequeue();
        }
    }
}
