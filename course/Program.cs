using course.Entities.classes;
using course.Entities.interfaces;
using course.interfaces;
using course.YourProjectNamespace.Common;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course.Forms;
using Newtonsoft.Json;
using System.Diagnostics.Contracts;
using System.IO;
using course.Repositories.ClassRepository;

namespace course
{
    internal class Program
    {
        static void Main()
        {
            string path = "..\\..\\Data\\DataWorker\\DataSecurity";
            SecuritiesJsonRepository rep = new SecuritiesJsonRepository(path);
            IAddress address = new AddressRU("Россия", "НСО", "Новосибирск", "Красный проспект", "28");

            Security Petr = new Security(2, "Петр", "Иванов", "Александрович", address, new Post("охранник", 32000m), 1, new TransportRU("А000АА", "Supra"), new PassportRu("1234", "123456"),
               new INNIndividualPerson("123456789012"), new PensionFoundRU("123456789012"), new Weapon("Ak-74", "12333"), new LicenseToCarryWeapon("12345678"), null);

            rep.Add(Petr);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ManagerForm());
        }
    }
}
