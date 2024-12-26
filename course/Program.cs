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
        static void Main(string[] args)
        {
            
            string path = "..\\..\\Data\\DataConsumer\\DataLegal";
            LegalConsumerJsonRepository _legalFileRepository = new LegalConsumerJsonRepository(path);
            List<LegalConsumer> filesLegal = _legalFileRepository.GetAll()
                    .Cast<LegalConsumer>()
                    .ToList();
            string path2 = "..\\..\\Data\\DataConsumer\\DataIndividual";
            IndividualConsumerJsonRepository _individualFileRepository = new IndividualConsumerJsonRepository(path2);
            List<LegalConsumer> filesind = _individualFileRepository.GetAll()
                    .Cast<LegalConsumer>()
                    .ToList();





            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManagerForm());
        }
    }
}
