using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface IAddress
    {
        string Country { get; set; }
        string Region { get; set; }
        string Locality { get; set; }
        string Street { get; set; }
        string Construction { get; set; }
    }
}
