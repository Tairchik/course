using course.Entities.classes;
using course.Entities.interfaces;
using course.interfaces;
using course.Repositories.ClassRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course.Forms
{
    public partial class ContractIndividualForm : Form
    {
        private IIndividualConsumer consumer;
        const string directoryPath = "..\\..\\Data\\DataContract";
        private readonly ContractsRepository contractsRepository = new ContractsRepository(directoryPath);
        const string directoryIndividualPath = "..\\..\\Data\\DataConsumer\\DataIndividual";
        private IndividualConsumerJsonRepository _individualFileRepository = new IndividualConsumerJsonRepository(directoryIndividualPath);

        public ContractIndividualForm(int consumerID)
        {
            try
            {
                consumer = _individualFileRepository.GetById(consumerID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InitializeComponent();
            LoadFilesIntoListBox();
        }
        private void LoadFilesIntoListBox()
        {
            try
            {
                if (consumer.Contracts != null)
                {
                    List<ContractClass> contractsFiles = consumer.Contracts
                   .Cast<ContractClass>()
                   .ToList();
                    // Очистить список перед добавлением
                    listBox.Items.Clear();

                    // Добавить имена файлов в listBox
                    foreach (var file in contractsFiles)
                    {
                        listBox.Items.Add(file.ID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка загрузки файлов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
                MessageBox.Show($"Вы выбрали: {listBox.SelectedItem}");
            else
                MessageBox.Show("Пожалуйста, выберите элемент из списка.");
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CreateIndividualEventForm consumerForm = new CreateIndividualEventForm(consumer.Id);
            consumerForm.Show();
            this.Hide();
        }
    }
}
