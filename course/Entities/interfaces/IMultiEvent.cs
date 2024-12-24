using course.interfaces;
using course.YourProjectNamespace.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.interfaces
{
    internal interface IMultiEvent : IEvent
    {
        ObjectType ObjectType_ { get; set; }
        double Square { get; set; }
    }
}
