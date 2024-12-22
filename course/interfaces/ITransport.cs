using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface ITransport
    {
        string CarName { get; set; }
        string RegisterNumber { get; set; }
    }
}
