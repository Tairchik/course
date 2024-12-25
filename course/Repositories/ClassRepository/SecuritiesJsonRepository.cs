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
    internal class SecuritiesJsonRepository : IRepository<ISecurity, string>
    {
        private readonly string path;
        private List<ISecurity> securities;

        public SecuritiesJsonRepository(string path)
        {
            this.path = path;
            securities = new List<ISecurity>();
            LoadData();
        }
        private void LoadData()
        {
            string[] securityFiles = Directory.GetFiles(path);
            string json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Newtonsoft.Json.Formatting.Indented };
            foreach (var securityFile in securityFiles)
            {
                json = File.ReadAllText(securityFile);
                securities.Add(JsonConvert.DeserializeObject<ISecurity>(json, options));
            }
        }
        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Newtonsoft.Json.Formatting.Indented };
            foreach (var security in securities)
            {
                fileName = $"{security.Surname + " " + security.Name + " " + security.Patronymic + " " + security.PassportData.Series + security.PassportData.Number}.json";
                filePath = path + "\\" + fileName;
                json = JsonConvert.SerializeObject(security, options);
                File.WriteAllText(filePath, json);
            }    
        }
        public void Add(ISecurity security)
        {
            securities.Add(security);
            SaveData();
        }
        public List<ISecurity> GetAll()
        {
            return securities;
        }

        public bool Remove(ISecurity security)
        {
            if (securities.Remove(security))
            {
                SaveData();
                return true;
            }
            return false;
        }

        public ISecurity GetById(string id)
        {
            var security = securities.FirstOrDefault(c => c.Surname + " " + c.Name + " " + c.Patronymic + " " + c.PassportData.Series + c.PassportData.Number == id);
            if (security == null)
                throw new Exception($"Работник {id} не найден");
            return security;
        }
        public void Update(ISecurity security)
        {
            string id = security.Surname + " " + security.Name + " " + security.Patronymic + " " + security.PassportData.Series + security.PassportData.Number;
            ISecurity existingSecurity = GetById(id);
            if (existingSecurity != null)
            {
                securities[securities.IndexOf(GetById(id))] = security;
                SaveData();
            }
            else
            {
                throw new Exception("Невозможно изменить работника, так как он не найден.");
            }
        }
    }
}

