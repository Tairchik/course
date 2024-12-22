using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal class Security : Worker, ISecurity
    {
        private IWeapon weapon;
        private ILicenseToCarryWeapon licenseToCarryWeapon;
        private ISchedule schedule;
        private string name;

        public new string Name 
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "Test")
                {
                    throw new ArgumentException("Its Work!");
                }
                else
                {
                    name = value;
                }
            }
        }

        public Security(IAddress address, string name, string surname, string patronymic, IPost post, IBonusSalary bonusSalary,
            ITransport transport, IPassport passport, IINN inn, IPensionFund pensionFund, IWeapon weapon, ILicenseToCarryWeapon licenseToCarryWeapon, ISchedule schedule) 
            : base( address, name, surname, patronymic, post, bonusSalary, transport, passport, inn, pensionFund)
        {
            Weapon = weapon;
            LicenseToCarryWeapon = licenseToCarryWeapon;
            Schedule = schedule;
        }

        public Security(IAddress address, string name, string surname, string patronymic, IPost post, IBonusSalary bonusSalary,
            IPassport passport, IINN inn, IPensionFund pensionFund, IWeapon weapon, ILicenseToCarryWeapon licenseToCarryWeapon, ISchedule schedule)
            : base(address, name, surname, patronymic, post, bonusSalary, passport, inn, pensionFund)
        {
            Weapon = weapon;
            LicenseToCarryWeapon = licenseToCarryWeapon;
            Schedule = schedule;
        }
        public IWeapon Weapon
        {
            get { return weapon; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Неверное оружие");
                }
                else 
                {
                    weapon = value;
                }
            }
        }
        public ILicenseToCarryWeapon LicenseToCarryWeapon 
        {
            get { return licenseToCarryWeapon; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Неверное лицензия на ношение оружия");
                }
                else
                {
                    licenseToCarryWeapon = value;
                }
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
    }
}
