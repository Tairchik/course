﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface ICalculateTotalAmount<T>
    {
        int CalculateTotalAmount(T eventData);
    }
}
