﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceGeneric
{
    interface ISorter<T> : IPrintable
    {
        void Sort();
    }
}
