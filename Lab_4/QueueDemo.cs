using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class QueueDemo
    {
        Queue q = new Queue();

        public void QueueMethod() {
            q.Enqueue("one");
            q.Enqueue("two");
            q.Enqueue("three");
            q.Enqueue("four");

            q.Dequeue();

            q.Peek();

            q.Contains("one");

            q.Clear();
        }
    }
}
