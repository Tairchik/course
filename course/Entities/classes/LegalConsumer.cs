using course.Entities.interfaces;
using course.interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class LegalConsumer : ILegalConsumer
    {
        private string companyName;
        private IAddress address;
        private List<IContract> contracts;

        public LegalConsumer(string companyName, IAddress address) 
        { 
            CompanyName = companyName;
            Address = address;
        }
        public void AddContract(IContract contract)
        {
            contracts.Add(contract);
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
    }
}
