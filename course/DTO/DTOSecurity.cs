using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.DTO
{
    internal class DTOSecurity
    {
        public int Id_ { get; set; }
        public string Name_ { get; set; }
        public string Surname_ { get; set; }
        public string Patronymic_ { get; set; }
        public AddressRU Address_ { get; set; }
        public Post PostData_ { get; set; }
        public Decimal BonusSalary_ { get; set; }
        public Schedule Schedule_ { get; set; } 
        public PassportRu PassportData_ { get; set; }
        public INNIndividualPerson INNData_ { get; set; }
        public PensionFoundRU PensionFundData_ { get; set; }
        public Weapon Weapon_ { get; set; } 
        public LicenseToCarryWeapon LicenseToCarryWeapon_ { get; set; } 
        public TransportRU TransportData_ { get; set; } 
    }

}
