using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceGeneric
{
    abstract class Sorter<T> : ISorter<T>
    {
        protected T[] array;

        public Sorter (T[] array)
        {
            this.array = array;
        }

        public abstract void Sort();

        public void Print()
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, array[i]);
            }
        }

        protected void Swap (ref T index1, ref T index2)
        {
            T temp = index1;
            index1 = index2;
            index2 = temp;
        }


    }
}