﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceGeneric
{
    interface IMyStack<T>
    {
        void Push(T data);
        T Pop();
    }
}
