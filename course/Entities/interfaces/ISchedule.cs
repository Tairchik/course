using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface ISchedule
    {
        List<DateTime> Schedule_ { get;}
        void Add(DateTime day);
        void Change(DateTime day, DateTime dayChange);
        void DeleteDay(DateTime day);
        //void GenerateSchedule();

    }
}
