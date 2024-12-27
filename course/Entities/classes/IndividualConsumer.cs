using course.Entities.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal class IndividualConsumer : IIndividualConsumer
    {
        private string name;
        private string surname;
        private string patronymic;
        private IAddress address;
        private List<IContract> contracts;
        private int id;


        public IndividualConsumer(string name, string surname, string patronymic, IAddress address, int id)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Address = address;
            Id = id;
        }
        public void AddContract(IContract contract)
        {
            contracts.Add(contract);
        }

        public int Id
        {
            get { return id; }
            private set
            {
                id = value;
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
        public List<IContract> Contracts
        {
            get { return contracts; }

        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Неверное имя");
                }
                else
                {
                    name = value;
                }
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Неверное Фамилия");
                }
                else
                {
                    surname = value;
                }
            }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Неверное отчество");
                }
                else
                {
                    patronymic = value;
                }
            }
        }
    }
}
