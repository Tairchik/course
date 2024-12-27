using course;
using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class MultiEvent : IMultiEvent
    {
        private IAddress address;
        private DateTime dateStart;
        private DateTime dateEnd;
        private ObjectType _objectType;
        private double square;
        private readonly ICalculateTotalAmount<IMultiEvent> _calculate;

        public MultiEvent(IAddress address, DateTime dateStart, DateTime dateEnd, ObjectType objectType, double square, ICalculateTotalAmount<IMultiEvent> calculate)
        {
            Address = address;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Square = square;
            ObjectType_ = objectType;
            _calculate = calculate;
        }
        public int CalculateAmount()
        {
            return _calculate.CalculateTotalAmount(this);
        }
        public ObjectType ObjectType_
        {
            get
            {
                return _objectType;
            }
            set
            {
                _objectType = value;
            }
        }

        public double Square
        {
            get
            {
                return square;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Неверное значение числа людей");
                }
                else
                {
                    square = value;
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
