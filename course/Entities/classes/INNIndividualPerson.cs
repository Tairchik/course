using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace course.Entities.classes
{
    internal class INNIndividualPerson : IINN
    {
        private string number;

        public INNIndividualPerson(string number)
        {
            Number = number;
        }
        public override string ToString()
        {
            return $"{number}";
        }

        static bool IsDigitString(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public string Number 
        { 
            get { return number; } 
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || !IsDigitString(value) || value.Length != 12)
                {
                    throw new ArgumentException("Неверный ИНН");
                } 
                else 
                {
                    number = value;
                }
            }
        }

    }
}
