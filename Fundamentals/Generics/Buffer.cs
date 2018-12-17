using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Generics
{
    public class Buffer<T> : IBuffer<T>
    {
        protected Queue<T> _queue = new Queue<T>();
        public virtual bool IsEmpty
        {
            get { return _queue.Count == 0; }
        }
        public virtual void Write(T element)
        {
            _queue.Enqueue(element);
        }

        public virtual T Read()
        {
            return _queue.Dequeue();
        }
    }
}
