using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class SingleEvent : ISingleEvent
    {
        private IAddress address;
        private DateTime dateStart;
        private DateTime dateEnd;
        private EventType _eventType;
        private int peoples;
        private readonly ICalculateTotalAmount<ISingleEvent> _calculator;

        public SingleEvent (IAddress address, DateTime dateStart, DateTime dateEnd, EventType eventType, int peoples)
        {
            Address = address;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Peoples = peoples;
            EventType_ = eventType;
        }

        public EventType EventType_
        {
            get
            {
                return _eventType;
            }
            set
            {
                _eventType = value;
            }
        }

        public int Peoples
        {
            get 
            { 
                return peoples; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Неверное значение числа людей");
                }
                else
                {
                    peoples = value;
                }
            }
        }

        public DateTime DateStart
        {
            get
            {
                return dateStart;
            }
            set 
            { 
                if (dateEnd == new DateTime()) 
                {
                    if (value == null) 
                    {
                        throw new ArgumentNullException("Неверное значение начало дня");
                    }
                    else
                    {
                        dateStart = value;
                    }
                }
                else
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException("Неверное значение начало дня");
                    }
                    else if (value.CompareTo(dateEnd) <= 0) 
                    {
                        dateStart = value;
                    }
                    else
                    {
                        throw new ArgumentException("Дата окончания не может быть раньше даты начала");
                    }
                }
            } 
        }

        public DateTime DateEnd
        {
            get
            {
                return dateEnd;
            }
            set
            {
                if (dateStart == new DateTime())
                {
                    if (value == new DateTime())
                    {
                        throw new ArgumentNullException("Неверное значение начало дня");
                    }
                    else
                    {
                        dateStart = value;
                    }
                }
                else
                {
                    if (value == new DateTime())
                    {
                        throw new ArgumentNullException("Неверное значение начало дня");
                    }
                    else if (dateStart.CompareTo(value) <= 0)
                    {
                        dateEnd = value;
                    }
                    else
                    {
                        throw new ArgumentException("Дата окончания не может быть раньше даты начала");
                    }
                }
            }
        }
        public IAddress Address
        {
            get
            {
                return address;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Неверный адрес");
                }
                else
                {
                    address = value;
                }
            }
        }
    }
}
