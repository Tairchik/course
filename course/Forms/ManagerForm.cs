using course;
using course.Entities.classes;
using course.interfaces;
using course.Repositories.ClassRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course.Forms
{
    public partial class ManagerForm : Form
    {
        private readonly LegalConsumerJsonRepository _legalFileRepository;
        private readonly IndividualConsumerJsonRepository _individualFileRepository;
        private readonly string directoryLegalPath = "..\\..\\Data\\DataConsumer\\DataLegal";
        private readonly string directoryIndividualPath = "..\\..\\Data\\DataConsumer\\DataIndividual";


        public ManagerForm()
        {
            InitializeComponent();
            try
            {
                _legalFileRepository = new LegalConsumerJsonRepository(directoryLegalPath);
                _individualFileRepository = new IndividualConsumerJsonRepository(directoryIndividualPath);
                LoadFilesIntoListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadFilesIntoListBox()
        {
            try
            {
                List<LegalConsumer> filesLegal = _legalFileRepository.GetAll()
                    .Cast<LegalConsumer>()
                    .ToList();
                List<IndividualConsumer> filesIndividual = _individualFileRepository.GetAll()
                    .Cast<IndividualConsumer>()
                    .ToList();
                // Очистить список перед добавлением
                listBox.Items.Clear();

                // Добавить имена файлов в listBox
                foreach (var file in filesLegal)
                {
                    listBox.Items.Add(file.CompanyName + "-" + file.Id.ToString() + "-" + "L"); // Отображает только имя файла
                }
                foreach (var fileInd in filesIndividual)
                {
                    listBox.Items.Add(fileInd.Name + " " + fileInd.Surname + " " + fileInd.Patronymic + "-" + fileInd.Id.ToString() + "-" + "I");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка загрузки файлов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                int selectList = int.Parse(listBox.SelectedItem.ToString().Split('-')[1]);
                string selectIorL = listBox.SelectedItem.ToString().Split('-')[2];
                if (listBox.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, выберите элемент для редактирования.");
                }
                else if (_legalFileRepository.GetById(selectList) != null && selectIorL == "L")
                {
                    ContractLegalForm editFrom = new ContractLegalForm(selectList);
                    editFrom.Show();
                    this.Hide();
                }
                else if (_individualFileRepository.GetById(selectList) != null && selectIorL == "I")
                {
                    ContractIndividualForm editForm = new ContractIndividualForm(selectList);
                    editForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int selectList = int.Parse(listBox.SelectedItem.ToString().Split('-')[1]);
                string selectIorL = listBox.SelectedItem.ToString().Split('-')[2];
                if (listBox.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, выберите элемент для редактирования.");
                }
                else if (_legalFileRepository.GetById(selectList) != null && selectIorL == "L")
                {
                    EditLegalConsumerForm editFrom = new EditLegalConsumerForm(selectList);
                    editFrom.Show();
                    this.Hide();
                }
                else if (_individualFileRepository.GetById(selectList) != null && selectIorL == "I")   
                {
                    EditIndividualConsumerForm editForm = new EditIndividualConsumerForm(selectList);
                    editForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            SelectedConsumerForm consumerForm = new SelectedConsumerForm();
            consumerForm.Show();
            this.Hide();
        }
    }
}