using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Schedule : ISchedule
    {
        private List<DayAndTime> _schedule;
        public Schedule()
        {
            Schedule_ = null;
        }
        public Schedule(List<DayAndTime> schedule)
        {
            Schedule_ = schedule;
        }

        public List<DayAndTime> Schedule_
        {
            get
            {
                return _schedule;
            }
            set
            {
                _schedule = value;
                SortSchedule();
            }
        }
        public void Add(DayAndTime day)
        {
            if (_schedule == null)
            {
                _schedule.Add(day);
            }
            else
            {
                int count = 0;
                foreach (DayAndTime t in _schedule)
                {
                    if (t.CompareTo(day) > 0)
                    {
                        _schedule.Insert(count, t);
                        break;
                    }
                    else if (t.CompareTo(day) == 0)
                    {
                        throw new ArgumentException($"Неверно значение. На изменяемую дату назначен день");
                    }
                    count++;
                }
            }
        }
        public void Change(DayAndTime day, DayAndTime dayChange) 
        {
            if (_schedule != null)
            {
                int count = 0;
                foreach (DayAndTime t in _schedule)
                {
                    if (t.Equals(dayChange))
                    {
                        _schedule[count] = day;
                        break;
                    }
                    count++;
                }
                if (count == _schedule.Count) 
                {
                    throw new ArgumentException($"Значение {dayChange.ToString()} не найдено");
                }
            }
            else
            {
                throw new ArgumentException("График пуст");
            }
        }
        public void DeleteDay(DayAndTime day)
        {
            if (_schedule != null)
            {
                if (!_schedule.Remove(day))
                {
                    throw new ArgumentException($"Значение {day.ToString()} не найдено");                
                }
            }
            else
            {
                throw new ArgumentNullException("График пуст");
            }
        }
        public void SortSchedule()
        {
            if (_schedule != null)
            {
                _schedule.Sort((a, b) => a.Date.CompareTo(b.Date));
            }
        }
    }
}
