using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class PassportRu : IPassport
    {
        private string series;
        private string number;

        public PassportRu(string series, string number)
        {
            Series = series;
            Number = number;
        }

        public override string ToString()
        {
            return $"{series} {number}";
        }
        public string Series 
        {  
            get { return series; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 4) 
                {
                    throw new ArgumentException("Неверная серия паспорта");
                }
                else
                {
                    series = value;
                }
            }
        }
        public string Number 
        { 
            get { return number; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 6)
                {
                    throw new ArgumentException("Неверный номер паспорта");
                }
                else
                {
                    number = value;
                }
            } 
        }
    }
}
