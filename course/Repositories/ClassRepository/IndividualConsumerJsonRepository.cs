using course.interfaces;
using Newtonsoft.Json;
using course.Repositories.InterfacesRepository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using course.Entities.interfaces;

namespace course.Repositories.ClassRepository
{
    internal class IndividualConsumerJsonRepository : IRepository<IIndividualConsumer, int>
    {
        private readonly string path;
        private List<IIndividualConsumer> consumers;

        public IndividualConsumerJsonRepository(string path)
        {
            this.path = path;
            consumers = new List<IIndividualConsumer>();
            LoadData();
        }
        private void LoadData()
        {
            string[] consumerFiles = Directory.GetFiles(path);
            string json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Newtonsoft.Json.Formatting.Indented };
            foreach (var consumerFile in consumerFiles)
            {
                json = File.ReadAllText(consumerFile);
                consumers.Add(JsonConvert.DeserializeObject<IIndividualConsumer>(json, options));
            }
        }
        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Newtonsoft.Json.Formatting.Indented };
            foreach (var consumer in consumers)
            {
                fileName = $"{consumer.Id}.json";
                filePath = path + "\\" + fileName;
                json = JsonConvert.SerializeObject(consumer, options);
                File.WriteAllText(filePath, json);
            }
        }
        public void Add(IIndividualConsumer consumer)
        {
            if (AnalyzerId(consumer.Id))
            {
                throw new ArgumentException($"Заказчик с таким id:{consumer.Id} уже существует");
            }
            consumers.Add(consumer);
            SaveData();
        }
        public List<IIndividualConsumer> GetAll()
        {
            return consumers;
        }

        private bool AnalyzerId(int id)
        {
            foreach (var consumer in consumers)
            {
               if (consumer.Id == id) return true;
            }
            return false;
        }
        public int GetUnicumId
        {
            get { return ReturnLastId() + 1; }
        }
        public int ReturnLastId()
        {
            int lastId = 0;
            foreach (var consumer in consumers)
            {
                if (lastId <= consumer.Id) 
                    lastId = consumer.Id;
            }
            return lastId;
        }

        public bool Remove(IIndividualConsumer consumer)
        {
            if (consumers.Remove(consumer))
            {
                SaveData();
                return true;
            }
            return false;
        }

        public IIndividualConsumer GetById(int id)
        {
            var consumer = consumers.FirstOrDefault(c => c.Id == id);
            if (consumer == null)
                throw new Exception($"Заказчик {id} не найден");
            return consumer;
        }
        public void Update(IIndividualConsumer consumer)
        {
            int id = consumer.Id;
            IConsumer existingConsumer = GetById(id);
            if (existingConsumer != null)
            {
                consumers[consumers.IndexOf(GetById(id))] = consumer;
                SaveData();
            }
            else
            {
                throw new Exception("Невозможно изменить заказчика, так как он не найден.");
            }
        }
    }
}
