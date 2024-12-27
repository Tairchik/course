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
        DateTime DateStartContract { get; set; }
        DateTime DateEndContract { get; set; }
        IEvent EventData { get; set; }
        int SecurityNum { get;}
        //IConsumer Consumer { get; set; }

    }
}
