﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceGeneric
{
    interface IMyQueue<T>
    {
        void Enqueue(T data);
        T Dequeue();
    }
}
