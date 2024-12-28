using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class ContractClass : IContract
    {
        private int id; // уникальный номер
        private int securityNum;
        private DateTime dateStartContract;
        private DateTime dateEndContract;
        private IEvent eventData;
        private List<ISecurity> securities;

        public ContractClass(int id, DateTime dateStart, DateTime dateEnd, IEvent eventData)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Неверный уникальный номер контракта");
            }
            else
            {
                this.id = id;
            }
            
            EventData = eventData;
            SecurityNum = eventData.CalculateAmount();
            DateStartContract = dateStart;
            DateEndContract = dateEnd;

        }
        public ContractClass(int id, IEvent eventData)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Неверный уникальный номер контракта");
            }
            else
            {
                this.id = id;
            }
            EventData = eventData;
            SecurityNum = eventData.CalculateAmount();
            DateStartContractAuto();
            DateEndContractAuto();

        }
        public List<ISecurity> Securities
        {
            get { return securities; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Охранники не объявлены");
                }
                else if (value.Count < securityNum)
                {
                    throw new ArgumentNullException("Недостаточное число назначенных охранников");
                }
                else
                {
                    securities = value;
                }
            }
        }
        public int SecurityNum
        {
            get
            {
                return securityNum;
            }
            private set
            {
                if (value <= 0) 
                {
                    throw new ArgumentException("Неверное значение числа охранников нужных для мероприятия");
                }
                else
                {
                    securityNum = value;
                }
            }
        }
        public IEvent EventData
        {
            get
            {
                return eventData;
            }
            set
            {
                if (value != null)
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
        public void DateStartContractAuto()
        {
            dateStartContract = DateTime.Now;
        }

        public void DateEndContractAuto()
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

        public DateTime DateStartContract
        {
            get
            {
                return dateStartContract;
            }
            set
            {
                if (value.Day < DateTime.Now.Day)
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
