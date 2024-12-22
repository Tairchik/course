﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course.interfaces;

namespace course
{
    internal class Person : IPerson
    {
        private IAddress address;
        public IAddress Address_
        {
            get
            {
                return address;
            }
            set
            {
                if (value != null) 
                {
                    throw new ArgumentNullException("Неверный адрес");
                }
                else
                {
                    address = value;
                }
            }
        }
        public override string ToString()
        {
            return Address_.ToString();
        }
    }
}
