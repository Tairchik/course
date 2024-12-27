using course.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class Weapon : IWeapon
    {
        private string name;
        private string registerNumber;
        public Weapon(string name, string registerNumber) 
        {
            Name = name;
            RegisterNumber = registerNumber;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Неверное название оружия");
                }
                else
                {
                    name = value;
                }
            }
        }
        public string RegisterNumber
        {
            get { return registerNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Неверный регистрационный номер оружия");
                }
                else
                {
                    registerNumber = value;
                }
            }
        }
        public override string ToString()
        {
            return $"{Name} {RegisterNumber}";
        }
    }
}
