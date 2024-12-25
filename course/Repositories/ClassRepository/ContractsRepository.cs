﻿using course.Entities.interfaces;
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
    internal class ContractsRepository : IRepository<IContract, int>
    {
        private readonly string path;
        private List<IContract> contracts;

        public ContractsRepository(string path)
        {
            this.path = path;
            contracts = new List<IContract>();
            LoadData();
        }
        private void LoadData()
        {
            string[] contractFiles = Directory.GetFiles(path);
            string json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Newtonsoft.Json.Formatting.Indented };
            foreach (var contractFile in contractFiles)
            {
                json = File.ReadAllText(contractFile);
                contracts.Add(JsonConvert.DeserializeObject<IContract>(json, options));
            }
        }
        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Newtonsoft.Json.Formatting.Indented };
            foreach (var contract in contracts)
            {
                fileName = $"{contract.ID}.json";
                filePath = path + "\\" + fileName;
                json = JsonConvert.SerializeObject(contract, options);
                File.WriteAllText(filePath, json);
            }
        }
        public void Add(IContract contract)
        {
            contracts.Add(contract);
            SaveData();
        }
        public IEnumerable<IContract> GetAll()
        {
            return contracts;
        }

        public bool Remove(IContract contract)
        {
            if (contracts.Remove(contract))
            {
                SaveData();
                return true;
            }
            return false;
        }

        public IContract GetById(int id)
        {
            var contract = contracts.FirstOrDefault(c => c.ID == id);
            if (contract == null)
                throw new Exception($"Контракт {id} не найден");
            return contract;
        }
        public void Update(IContract contract)
        {
            int id = contract.ID;
            IContract existingConsumer = GetById(id);
            if (existingConsumer != null)
            {
                contracts[contracts.IndexOf(GetById(id))] = contract;
                SaveData();
            }
            else
            {
                throw new Exception("Невозможно изменить контракт, так как он не найден.");
            }
        }
    }
}