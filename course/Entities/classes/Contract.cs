using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class Contract : IContract
    {
        private int id; // уникальный номер
        private DateTime dateStartContract;
        private DateTime dateEndContract;
        private IEvent eventData;

        public Contract(int id, DateTime dateStart, DateTime dateEnd, IEvent eventData)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Неверный уникальный номер контракта");
            }
            else
            {
                this.id = id;
            }
            DateStartContract = dateStart;
            DateEndContract = dateEnd;
            EventData = eventData;

        }
        public IEvent EventData
        {
            get
            {
                return eventData;
            }
            set
            {
                if (eventData != null)
                {
                    eventData = value;
                }
                else
                {
                    throw new ArgumentException("Неверное значение мероприятия");
                }
            }
        }
        public int ID 
        { 
            get 
            { 
                return id; 
            } 
        }
        public DateTime DateStartContractAuto 
        {
            set
            {
                dateStartContract = DateTime.Now;
            }
        }
        public DateTime DateEndContractAuto
        {
            set 
            { 
                if (eventData.DateEnd == null) 
                { 
                    throw new ArgumentException("Для создания даты окончания контракта, нужно инициализировать Мероприятие"); 
                }
                else 
                {
                    dateEndContract = eventData.DateEnd;
                }
            }
        }
        public DateTime DateStartContract
        {
            get
            {
                return dateStartContract;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("Неверное значение даты начала контракта");
                }
                else
                {
                    dateStartContract = value;
                }
            }
        }
        public DateTime DateEndContract
        {
            get
            {
                return dateEndContract;
            }
            set
            {
                if (eventData.DateEnd == null)
                {
                    throw new ArgumentException("Для создания даты окончания контракта, нужно инициализировать Мероприятие");
                }
                else if (value < eventData.DateEnd)
                {
                    throw new ArgumentException("Неверное значение даты окончания контракта");
                }
                else
                {
                    dateEndContract = value;
                }
            }
        }
    }
}
