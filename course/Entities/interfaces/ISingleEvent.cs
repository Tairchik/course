using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface ISingleEvent : IEvent
    {
        int Peoples { get; set; }
        EventType EventType_ { get; set; }

    }
}
