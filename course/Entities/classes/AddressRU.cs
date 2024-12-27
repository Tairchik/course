using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class AddressRU : IAddress
    {
        private string country;
        private string region;
        private string locality;
        private string street;
        private string construction;
        public AddressRU(string country, string region, string locality, string street, string construction)
        {
            Country = country;
            Region = region;
            Locality = locality;
            Street = street;
            Construction = construction;
        }

        public override string ToString() 
        {
            return $"{Country} {Region} {Locality} {Street} {Construction}";
        }
        public string Country
        {
            get { return country; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Неверная страна");
                }
                else
                {
                    country = value;
                }
            }
        }
        public string Region
        {
            get { return region; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Неверный регион");
                }
                else
                {
                    region = value;

                }
            }
        }
        public string Locality
        {
            get { return locality; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Неверный населенный пункт");
                }
                else
                {
                    locality = value;
                }
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Неверная улица");
                }
                else
                {
                    street = value;
                }
            }
        }
        public string Construction
        {
            get
            {
                return construction;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Неверное сооружение");
                }
                else
                {
                    construction = value;
                }
            }
        } 
    }
}
