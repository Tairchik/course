using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface IPassport
    {
        string Series { get; set; }
        string Number { get; set; }
    }
}
