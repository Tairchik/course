using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Address
    {
        private string country;
        private string region;
        private string locality;
        private string street;
        private string construction;

        public string Country
        {
            get { return country; }
            set
            {
                if (string.IsNullOrEmpty(country))
                {
                    throw new ArgumentNullException("Поле <страна> не может быть пустой");
                }
                country = value;
            }
        }
        public string Region
        {
            get { return region; }
            set
            {
                if (string.IsNullOrEmpty(region))
                {
                    throw new ArgumentNullException("Поле <страна> не может быть пустой");
                }
                region = value;
            }
        }
        public string Locality
        {
            get { return locality; }
            set
            {
                if (string.IsNullOrEmpty(locality))
                {
                    throw new ArgumentNullException("Поле <страна> не может быть пустой");
                }
                locality = value;
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
                if (string.IsNullOrEmpty(street))
                {
                    throw new ArgumentNullException("Поле <страна> не может быть пустой");
                }
                street = value;
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
                if (string.IsNullOrEmpty(construction))
                {
                    throw new ArgumentNullException("Поле <страна> не может быть пустой");
                }
                construction = value;
            }
        }

        public Address (string country, string region, string locality, string street, string construction) 
        {
            Country = country;
            Region = region;
            Locality = locality;
            Street = street;
            Construction = construction;
        }
    }
}
