using course.interfaces;
using course.Entities;
using course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface IMultiEvent : IEvent
    {
        ObjectType ObjectType_ { get; set; }
        double Square { get; set; }
    }
}
