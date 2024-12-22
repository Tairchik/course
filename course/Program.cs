using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Security security = new Security(new AddressRU("Russia", "Новосибирская область", "Новосибирск", "Тюленина", "дом 28")
                ,"Test", "Иванов", "Петрович", new Post("Старший охранник", 45000m), new BonusSalary(5000),
                new PassportRu("5020", "042490"), new INNIndividualPerson("123456789012"), new PensionFoundRU("123456789012"),
                new Weapon("Ak-47", "AK1232"), new LicenseToCarryWeapon("12332112"), new Schedule());
            Console.WriteLine(security.Name);
            Console.WriteLine(security.Surname);

        }
    }
}
