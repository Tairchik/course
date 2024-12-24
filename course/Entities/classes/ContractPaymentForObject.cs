using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class ContractPaymentForObject : IContractPayment
    {
        public Decimal CalculateCost(List<ISecurity> securities)
        {
            Decimal sum = 0;

            foreach (var security in securities)
            {
                sum += security.PostData.Salary;
            }
            return sum;
        }
    }
}
