using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceGeneric
{
    class InsertionSorter<T> : Sorter<T> where T : IComparable
    {
        public InsertionSorter(T[] array) : base (array)
        { }

        public override void Sort()
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = j + 1; i > 0; i--)
                {
                    if (array[i-1].CompareTo(array[i]) > 0)
                    {
                        Swap(ref array[i-1], ref array[i]);
                    }
                }
            }
        }

    }
}
