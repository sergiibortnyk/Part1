using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceGeneric
{
    interface IMyRingBuffer<T>
    {
        void Add (T data);
        T Remove ();
    }
}
