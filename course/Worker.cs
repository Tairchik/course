using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Worker : Person, IWorker
    {
        private string name;
        private string surname;
        private string patronymic;
        private IPost postData;
        private IBonusSalary bonusSalary;
        private ITransport transportData;
        private IPassport passportData;
        private IINN innData;
        private IPensionFund pensionFundData;


        public Worker(IAddress address, string name, string surname, string patronymic, IPost post, IBonusSalary bonusSalary, 
            ITransport transport, IPassport passport, IINN inn, IPensionFund pensionFund) : base(address)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            PostData = post;
            BonusSalary = bonusSalary;
            TransportData = transport;
            PassportData = passport;
            INNData = inn;
            PensionFundData = pensionFund;
        }
        public Worker(IAddress address, string name, string surname, string patronymic, IPost post, IBonusSalary bonusSalary,
            IPassport passport, IINN inn, IPensionFund pensionFund) : base(address)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            PostData = post;
            BonusSalary = bonusSalary;
            PassportData = passport;
            INNData = inn;
            PensionFundData = pensionFund;
        }
        public string Name
        {
            get { return name; } 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Неверное имя");
                }
                else
                {
                    name = value;
                }
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Неверное Фамилия");
                }
                else
                {
                    surname = value;
                }
            }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Неверное отчество");
                }
                else
                {
                    name = value;
                }
            }
        }
        public IPost PostData
        {
            get { return postData; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Неверная Должность");
                }
                else
                {
                    postData = value;
                }
            }
        }
        public IBonusSalary BonusSalary
        {
            get { return bonusSalary; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentException("Неверная надбавка к зарплате");
                }
                else
                {
                    bonusSalary = value;
                }
            }
        }
        public ITransport TransportData
        {
            get { return transportData; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Неверный транспорт");
                }
                else
                {
                    transportData = value;
                }
            }
        }
        public IPassport PassportData
        {
            get { return passportData; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Неверные паспорта");
                }
                else
                {
                    passportData = value;
                }
            }
        }

        public IINN INNData
        {
            get { return innData; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Неверный ИНН");
                }
                else
                {
                    innData = value;
                }
            }
        }

        public IPensionFund PensionFundData
        {
            get { return pensionFundData; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Неверный ПФР");
                }
                else
                {
                    pensionFundData = value;
                }
            }
        }
    }
}
