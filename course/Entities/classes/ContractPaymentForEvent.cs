using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class ContractPaymentForEvent : IContractPayment
    {
       public Decimal CalculateCost(List<ISecurity> securities) 
       {
            int oneHourCost = CalculateOneHourCost(securities);
            int count = 0;
            Decimal sum = 0;

            foreach (var security in securities)
            {
                sum = sum + security.BonusSalary;
                count ++;
            }
            return oneHourCost * count * 24 + sum;
        }
        private int CalculateOneHourCost(List<ISecurity> securities)
        {
            int count = securities.Count;
            if (count == 0)
            {
                throw new ArgumentException("Нулевое число охранников");
            }
            else if (count <= 5)
            {
                return 3000;
            }
            else if (count <= 10) 
            { 
                return 2500; 
            }
            else if (count <= 20) 
            { 
                return 2300; 
            }
            else if (count <= 50) 
            {
                return 2000; 
            }
            else if (count <= 100) 
            { 
                return 1500; 
            }
            else return 1000;
        }
    }
}
