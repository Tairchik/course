using course.interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class LegalConsumer : IConsumer
    {
        private string companyName;
        private IAddress address;
        private List<IContract> contracts;

        public LegalConsumer(string companyName, IAddress address, IContract contract) 
        { 
            CompanyName = companyName;
            Address = address;
            contracts.Add(contract);
        }
        public LegalConsumer(string companyName, IAddress address, List<IContract> contract)
        {
            CompanyName = companyName;
            Address = address;
            foreach (var item in contract)
            {
                contracts.Add(item);
            }
        }
        public List<IContract> Contracts 
        {
            get {  return contracts; }
            set 
            {

                if (value == null)
                {
                    throw new ArgumentNullException("Неверный список контрактов");
                }
                else
                {
                    contracts = value;
                }
            }
        }

        public string CompanyName 
        {
            get { return companyName; }
            set
            {

                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Неверный название компании");
                }
                else
                {
                    companyName = value;
                }
            }
        }
        public IAddress Address
        {
            get
            {
                return address;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Неверный адрес");
                }
                else
                {
                    address = value;
                }
            }
        }
        public string GetConsumerInfo() // Доработать
        { 
            return $"{CompanyName}";
        }
    }
}
