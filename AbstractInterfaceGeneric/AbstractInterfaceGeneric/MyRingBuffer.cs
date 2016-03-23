using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceGeneric
{
    class MyRingBuffer<T> : Buffer<T>, IMyRingBuffer<T>
    {
        protected int addpointer = 0;
        protected int removepointer = 0;

        public MyRingBuffer(int Lenght) : base(Lenght) { }

        public void Add(T data)
        {
            if (!IsFull())
            {
                for (int i = addpointer; i < pointer; i++)
                {
                    array[addpointer] = data;
                    addpointer++;
                    pointer++;
                }
                
            }
            else
            {
                Console.WriteLine("Buffer is Full");
            }
        }

        public T Remove()
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
                Console.WriteLine("Buffer is Empty");
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
                Console.WriteLine("Stack is Empty");
                return default(T);
            }
        }

    }
}
