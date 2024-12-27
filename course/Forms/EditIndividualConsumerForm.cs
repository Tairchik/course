using course;
using course.Entities.classes;
using course.interfaces;
using course.Repositories.ClassRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course.Forms
{
    public partial class EditIndividualConsumerForm : Form
    {
        const string directoryPath = "..\\..\\Data\\DataConsumer\\DataIndividual";
        private IndividualConsumerJsonRepository _individualFileRepository = new IndividualConsumerJsonRepository(directoryPath);
        private int consumerID;
        private IIndividualConsumer consumer;

        public EditIndividualConsumerForm(int id)
        {
            try
            {
                consumer = _individualFileRepository.GetById(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            consumerID = id;
            InitializeComponent();
            lblIdText.Text = $"{id}";
            txtFirstName.Text = consumer.Name;
            txtLastName.Text = consumer.Surname;
            txtMiddleName.Text = consumer.Patronymic;
            txtCountry.Text = consumer.Address.Country;
            txtRegion.Text = consumer.Address.Region;
            txtCity.Text = consumer.Address.Locality;
            txtStreet.Text = consumer.Address.Street;
            txtBuildingNumber.Text = consumer.Address.Construction;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                // Создание объекта клиента
                IAddress consumerAddress = new AddressRU(txtCountry.Text, txtRegion.Text, txtCity.Text, txtStreet.Text, txtBuildingNumber.Text);
                IIndividualConsumer consumerNew = new IndividualConsumer(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, consumerAddress, consumerID);

                // Определение пути для сохранения файла
                _individualFileRepository.Update(consumerNew);

                ManagerForm form = new ManagerForm();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ManagerForm form1 = new ManagerForm();
            form1.Show();
            this.Close();
        }
        private Label lblFirstName;
        private TextBox txtFirstName;

        private Label lblLastName;
        private TextBox txtLastName;

        private Label lblMiddleName;
        private TextBox txtMiddleName;

        private Label lblCountry;
        private TextBox txtCountry;

        private Label lblRegion;
        private TextBox txtRegion;

        private Label lblCity;
        private TextBox txtCity;

        private Label lblStreet;
        private TextBox txtStreet;

        private Label lblBuildingNumber;
        private TextBox txtBuildingNumber;

        private Button btnSave;
        private Button btnExit;

        private Label lblId;
        private Label lblIdText;
    }
}
