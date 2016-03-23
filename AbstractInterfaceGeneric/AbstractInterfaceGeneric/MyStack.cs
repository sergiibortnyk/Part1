using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceGeneric
{
    class MyStack<T> : Buffer<T>, IMyStack<T>
    {
        public MyStack(int Lenght) : base(Lenght) { }


        public void Push(T data)
        {
            if (!IsFull())
            {
                array[pointer] = data;
                pointer++;
            }
            else
            {
                Console.WriteLine("Stack is Full");
            }
        }

        public T Pop()
        {
            if (!IsEmpty())
            {
                return array[--pointer];
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return default(T);
            }

        }
        public override T Peek()
        {
            if (!IsEmpty())
            {
                return array[pointer - 1];
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return default(T);
            }

        }

    }
}
