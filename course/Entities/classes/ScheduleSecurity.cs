using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class ScheduleSecurity : ISchedule
    {
        private List<DateTime> _schedule;


        public List<DateTime> Schedule_
        {
            get
            {
                return _schedule;
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
                    if (t >= day)
                    {
                        if ((day - t).Days > 2)
                        {
                            _schedule.Insert(count, day);
                            break;
                        }    
                        else throw new ArgumentException($"Нельзя назначить дату на этот день");
                    }
                    count++;
                }
                if (count == _schedule.Count)
                {
                    if ((day - _schedule[count]).Days > 2)
                    {
                        _schedule.Add(day);
                    }
                    else throw new ArgumentException($"Нельзя назначить дату на этот день");
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