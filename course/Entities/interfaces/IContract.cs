using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface IContract
    {
        int ID { get;}
        DateTime DateStart { get; set; }
        DateTime DateEnd { get; set; }
        IEvent Event { get; set; }
        IConsumer Consumer { get; set; }
        
    }
}
