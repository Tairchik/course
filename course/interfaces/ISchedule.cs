using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface ISchedule
    {
        List<DayAndTime> Schedule_ { get; set; }
        void Add(DayAndTime day);
        void Change(DayAndTime day, DayAndTime dayChange);
        void DeleteDay(DayAndTime day);
        //void GenerateSchedule();

    }
}
