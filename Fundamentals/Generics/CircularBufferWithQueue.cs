using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Generics
{
    public class CircularBufferQueue<T> : Buffer<T>
    {
        private int _capacity;
        
        public CircularBufferQueue(int capacity = 3)
        {
            _capacity = capacity;
        }
        public override void Write(T value)
        {
            base.Write(value);

            if (_queue.Count > _capacity)
            {
                _queue.Dequeue();
            }
        }

        public bool IsFull
        {
            get { return _queue.Count == _capacity; }
        }
    }
}
