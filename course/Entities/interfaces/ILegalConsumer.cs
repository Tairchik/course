using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface ILegalConsumer : IConsumer
    {
        string CompanyName { get; set; }
    }
}
