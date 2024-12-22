using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal class BonusSalary : IBonusSalary
    {
        private Decimal bonusSalary;
    
        public BonusSalary(decimal bonusSalary)
        {
            BonusSalary_ = bonusSalary;
        }

        public Decimal BonusSalary_
        {
            get { return bonusSalary; }
            set 
            { 
                if (value.CompareTo(0) < 0) 
                {
                    throw new ArgumentException("Неверное значение надбавки");
                }
                else
                {
                    bonusSalary = value;
                }
            }
        }
        public void CalculateBonusSalary(ISchedule schedule)
        {
            BonusSalary_ = 1000; 
        }
    }
}
