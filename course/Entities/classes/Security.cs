using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class Security : ISecurity
    {
        private IWeapon weapon;
        private ILicenseToCarryWeapon licenseToCarryWeapon;
        private ISchedule schedule;

        private IAddress address;

        private string name;
        private string surname;
        private string patronymic;
        private IPost postData;
        private decimal bonusSalary;
        private ITransport transportData;
        private IPassport passportData;
        private IINN innData;
        private IPensionFund pensionFundData;

        private int id;

        

        public Security(int id, string name, string surname, string patronymic, IAddress address, IPost post, decimal bonusSalary,
            ITransport transport, IPassport passport, IINN inn, IPensionFund pensionFund, IWeapon weapon, ILicenseToCarryWeapon licenseToCarryWeapon, ISchedule schedule) 
        {
            Id = id;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Address = address;
            
            BonusSalary = bonusSalary;
            TransportData = transport;
            PassportData = passport;
            INNData = inn;
            PensionFundData = pensionFund;
            Weapon = weapon;
            LicenseToCarryWeapon = licenseToCarryWeapon;
            Schedule = schedule;
            PostData = post;
        }

        public int Id
        {
            get { return id; }
            private set
            {
                if (value <= 0) 
                {
                    throw new ArgumentException("Неверный ID");
                }
                else
                {
                    id = value;
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
        public IWeapon Weapon
        {
            get { return weapon; }
            set
            {
                weapon = value;
            }
        }
        public ILicenseToCarryWeapon LicenseToCarryWeapon 
        {
            get { return licenseToCarryWeapon; }
            set
            {
               licenseToCarryWeapon = value;
            }
        }
        public ISchedule Schedule 
        {
            get { return schedule; }
            set
            {
                schedule = value;
            }
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
                    patronymic = value;
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
        public decimal BonusSalary
        {
            get { return bonusSalary; }
            set
            {
                if (value < 0)
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
                transportData = value;
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
