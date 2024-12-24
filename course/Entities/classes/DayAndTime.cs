using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class DayAndTime
    {
        private DateTime date;
        private TimeSpan timeStart;
        private TimeSpan timeEnd;
        public DayAndTime(DateTime date, TimeSpan timeStart, TimeSpan timeEnd)
        {
            Date = date;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
        }
        public int CompareTo(DayAndTime input) 
        {
            if (date.CompareTo(input.Date) > 0)
            {
                return 1;
            }
            else if (date.CompareTo(input.Date) < 0)
            {
                return -1;
            }
            else
            {
                if (timeStart.CompareTo(input.TimeStart) < 0) 
                {

                    return 1;
                }
                else if (timeStart.CompareTo(input.TimeStart) > 0) 
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date.CompareTo(DateTime.Now) < 0 || date == null)
                {
                    throw new ArgumentException("Неверно указана дата");
                }
                else
                {
                    date = value;
                }
            }
        }
        public TimeSpan TimeStart
        {
            get { return timeStart; }
            set
            {
                if ((TimeStart == null || TimeEnd == null) && value != null)
                {
                    timeStart = value;
                }
                else if (value == null) 
                {
                    throw new ArgumentNullException("Неверное время");
                }
                else if (TimeStart.CompareTo(TimeEnd) < 0)
                {
                    timeStart = value;
                }
                else
                {
                    throw new ArgumentException("Время начала дня не может быть позже времени окончания дня");
                }
            }
        }
        public TimeSpan TimeEnd
        {
            get { return timeEnd; }
            set
            {
                if ((TimeStart == null || TimeEnd == null) && value != null)
                {
                    timeEnd = value;
                }
                else if (value == null)
                {
                    throw new ArgumentNullException("Неверное время");
                }
                else if (TimeStart.CompareTo(TimeEnd) < 0)
                {
                    timeEnd = value;
                }
                else
                {
                    throw new ArgumentException("Время начала дня не может быть позже времени окончания дня");
                }
            }
        }
        public override string ToString()
        {
            return $"{Date} {TimeStart} - {TimeEnd}";
        }
    }
}
