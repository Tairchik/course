﻿using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class TransportRU : ITransport
    {
        private string registerNumber;
        private string carName;
        string patternRUCar = @"^[АВЕКМНОРСТУХ]{1}[0-9]{3}[АВЕКМНОРСТУХ]{2}[- ]?[0-9]{2,3}$";
        string patternRUMotorcycle = @"^[0-9]{4}[АВЕКМНОРСТУХ]{2}[- ]?[0-9]{2,3}$"; 

        public TransportRU(string registerNumber, string carName)
        {
            CarName = carName;
            RegisterNumber = registerNumber;
        
        }

        public override string ToString()
        {
            return $"{registerNumber} {carName}";
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
               // else if (!Regex.IsMatch(value.ToUpper(), patternRUCar) && !Regex.IsMatch(value.ToUpper(), patternRUMotorcycle))
               // {
//throw new ArgumentException("Неверный регистрационный номер транспорта");
                //}
                else
                {
                    registerNumber = value.ToUpper();
                }
            }
        }
    }
}
