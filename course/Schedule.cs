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
        private List<DateTime> _schedule;
        public Schedule()
        {
            Schedule_ = null;
        }
        public Schedule(List<DateTime> schedule)
        {
            Schedule_ = schedule;
        }

        public List<DateTime> Schedule_
        {
            get
            {
                return _schedule;
            }
            set
            {
                _schedule = value;
                _schedule.Sort();
            }
        }
        public void Add(DateTime day)
        {
            if (_schedule == null)
            {
                _schedule.Add(day);
            }
            else
            {
                int count = 0;
                foreach (var t in _schedule)
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
        public void Change(DateTime day, DateTime dayChange) 
        {
            if (_schedule != null)
            {
                int count = 0;
                foreach (var t in _schedule)
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
        public void DeleteDay(DateTime day)
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
    }
}
