using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class PensionFoundRU : IPensionFund 
    {
        private string number;

        public PensionFoundRU(string number)
        {
            Number = number;
        }

        public string Number
        {
            get { return number; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)
                    || !IsDigitString(value) || value.Length < 12)
                {
                    throw new ArgumentException("Неверный номер ПФР");
                }
                else
                {
                    number = value;
                }
            }
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
    }
}
