using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace course
{
    internal class LicenseToCarryWeapon : ILicenseToCarryWeapon
    {
        private string licenseName;

        public LicenseToCarryWeapon(string licenseName)
        {
            LicenseName = licenseName;
        }

        public string LicenseName
        {
            get { return licenseName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length != 8 || !IsDigitString(value))
                {
                    throw new ArgumentException("Неверная лицензия на ношение оружия");
                }
                else
                {
                    licenseName = value;
                }
            }
        }
        static bool IsDigitString(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
