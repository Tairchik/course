using course.Entities.interfaces;
using course.interfaces;
using course.Repositories.ClassRepository;
using course.Repositories.InterfacesRepository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace course.Controllers
{
    internal class MainController
    {
        private string pathIndividual = "..\\course\\Data\\DataConsumer\\DataConsumer";
        private string pathLegal = "..\\course\\Data\\DataConsumer\\DataLegal";
        public IRepository<IIndividualConsumer, string> dataIndividual;
        public IRepository<ILegalConsumer, string> dataLegal;
        public MainController()
        {
            dataIndividual = new IndividualConsumerJsonRepository(pathIndividual);
            dataLegal = new LegalConsumerJsonRepository(pathLegal);
        }

     
    }
}
