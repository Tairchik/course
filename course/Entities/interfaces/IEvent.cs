using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface IEvent
    {
        IAddress Address { get; set; }
        DateTime DateStart { get; set; }
        DateTime DateEnd { get; set; }
    }
}
