using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceGeneric
{
    class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {
        public MyQueue(int Lenght) : base(Lenght) { }

        public void Enqueue(T data)
        {
            if (!IsFull())
            {
                array[pointer] = data;
                pointer++;
            }
            else
            {
                Console.WriteLine("Queue is Full");
            }
        }

        public T Dequeue()
        {
            if (!IsEmpty())
            {
                T temp = array[0];
                for (int i = 0; i < pointer - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                pointer--;
                return temp;
            }
            else
            {
                Console.WriteLine("Queue is Empty");
                return default(T);
            }
        }

        public override T Peek()
        {
            if (!IsEmpty())
            {
                return array[0];
            }
            else
            {
                Console.WriteLine("Queue is Empty");
                return default(T);
            }
        }

    }
}