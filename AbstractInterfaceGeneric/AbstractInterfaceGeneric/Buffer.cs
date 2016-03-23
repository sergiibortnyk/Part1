using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceGeneric
{
    abstract class Buffer<T> : IBuffer<T>
    {
        protected T[] array=null;
        protected int pointer = 0;

        public Buffer(int Lenght)
        {
            array = new T [Lenght];
        }

        public bool IsEmpty()
        {
            if (pointer == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if (pointer == array.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public abstract T Peek();       

        public void Print()
        {
            if (!IsEmpty())
            {
                for (int i = 0; i < pointer; i++)
                {

                    Console.Write("| {0} | ", array[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Buffer is Empty");
            }
        }
    }
}
