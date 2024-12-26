using course.Entities.interfaces;
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
    public partial class EditLegalConsumerForm : Form
    {
        const string directoryLegalPath = "..\\..\\Data\\DataConsumer\\DataLegal";
        private LegalConsumerJsonRepository _legalFileRepository = new LegalConsumerJsonRepository(directoryLegalPath);

        private ILegalConsumer consumer;
        public EditLegalConsumerForm(string id)
        {
      
            consumer = _legalFileRepository.GetById(id);
            InitializeComponent();
            txtCompanyName.Text = consumer.CompanyName;
            txtCountry.Text = consumer.Address.Country;
            txtRegion.Text = consumer.Address.Region;
            txtCity.Text = consumer.Address.Locality;
            txtStreet.Text = consumer.Address.Street;
            txtBuildingNumber.Text = consumer.Address.Construction;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Создание объекта клиента
                IAddress consumerAddress = new AddressRU(txtCountry.Text, txtRegion.Text, txtCity.Text, txtStreet.Text, txtBuildingNumber.Text);
                ILegalConsumer consumerNew = new LegalConsumer(txtCompanyName.Text, consumerAddress);

                // Определение пути для сохранения файла
                _legalFileRepository.Update(consumerNew);
               

                ManagerForm form = new ManagerForm();
                form.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBackToMenu_Click(object sender, EventArgs e)
        {
            ManagerForm form1 = new ManagerForm();
            form1.Show();
            this.Hide();
        }
        private Label lblCompanyName;
        private TextBox txtCompanyName;

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
        private Button btnBackToMenu;
    }
}
