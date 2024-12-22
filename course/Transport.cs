using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Transport : ITransport
    {

        private string registerNumber;
        private string carName;

        public Transport(string registerNumber, string carName)
        {
            CarName = carName;
            RegisterNumber = registerNumber;
        }

        public string CarName 
        {
            get 
            {
                return carName;
            }
            set 
            { 
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) 
                {
                    throw new ArgumentException("Неверное название транспорта");
                }
                else
                {
                    carName = value;
                }
            } 
        }
        public string RegisterNumber 
        {
            get
            {
                return registerNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Неверный регистрационный номер транспорта");
                }
                else
                {
                    registerNumber = value;
                }
            }
        }
    }
}
