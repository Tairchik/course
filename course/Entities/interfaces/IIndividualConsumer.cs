using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface IIndividualConsumer : IConsumer
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Patronymic { get; set; }


    }
}
