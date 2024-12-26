using course.Entities.interfaces;
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


        public ManagerForm()
        {
            InitializeComponent();

            string directoryLegalPath = "..\\..\\Data\\DataConsumer\\DataLegal";
            string directoryIndividualPath = "..\\..\\Data\\DataConsumer\\DataIndividual";

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
                    listBox.Items.Add(Path.GetFileName(file.CompanyName)); // Отображает только имя файла
                }
                foreach (var fileInd in filesIndividual)
                {
                    listBox.Items.Add(Path.GetFileName(fileInd.Name + " " + fileInd.Surname + " " + fileInd.Patronymic));
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_legalFileRepository.GetById(listBox.SelectedItem.ToString()) is ILegalConsumer)
            {
                EditLegalConsumerForm editFrom = new EditLegalConsumerForm(listBox.SelectedItem.ToString());
                editFrom.Show();

                this.Hide();
            }
            else if (_individualFileRepository.GetById(listBox.SelectedItem.ToString()) is IIndividualConsumer)
            {

            }
            else if (listBox.SelectedItem != null)
                MessageBox.Show($"Редактирование: {listBox.SelectedItem}");
            else
                MessageBox.Show("Пожалуйста, выберите элемент для редактирования.");
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            SelectedConsumerForm consumerForm = new SelectedConsumerForm();
            consumerForm.Show();
            this.Hide();
        }
    }
}