using course.Entities.interfaces;
using course.interfaces;
using course.Repositories.InterfacesRepository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Repositories.ClassRepository
{
    internal class LegalConsumerJsonRepository : IRepository<ILegalConsumer, string>
    {
        private readonly string path;
        private List<ILegalConsumer> consumers;

        public LegalConsumerJsonRepository(string path)
        {
            this.path = path;
            consumers = new List<ILegalConsumer>();
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
                consumers.Add(JsonConvert.DeserializeObject<ILegalConsumer>(json, options));
            }
        }
        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Newtonsoft.Json.Formatting.Indented };
            foreach (var consumer in consumers)
            {
                fileName = $"{consumer.CompanyName}.json";
                filePath = path + "\\" + fileName;
                json = JsonConvert.SerializeObject(consumer, options);
                File.WriteAllText(filePath, json);
            }
        }
        public void Add(ILegalConsumer consumer)
        {
            consumers.Add(consumer);
            SaveData();
        }
        public List<ILegalConsumer> GetAll()
        {
            return consumers;
        }

        public bool Remove(ILegalConsumer consumer)
        {
            if (consumers.Remove(consumer))
            {
                SaveData();
                return true;
            }
            return false;
        }

        public ILegalConsumer GetById(string id)
        {
            var consumer = consumers.FirstOrDefault(c => c.CompanyName == id);
            if (consumer == null)
                throw new Exception($"Заказчик {id} не найден");
            return consumer;
        }
        public void Update(ILegalConsumer consumer)
        {
            string id = consumer.CompanyName;
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