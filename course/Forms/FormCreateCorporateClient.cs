using course.Entities.interfaces;
using course.interfaces;
using course.Repositories.ClassRepository;
using Newtonsoft.Json;
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
    public partial class FormCreateCorporateClient : Form
    {
        const string directoryLegalPath = "..\\..\\Data\\DataConsumer\\DataLegal";
        private LegalConsumerJsonRepository _legalFileRepository = new LegalConsumerJsonRepository(directoryLegalPath);

        public FormCreateCorporateClient()
        {
            InitializeComponent();
  
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Создание объекта клиента
                IAddress consumerAddress = new AddressRU(txtCountry.Text, txtRegion.Text, txtCity.Text, txtStreet.Text, txtBuildingNumber.Text);
                ILegalConsumer consumer = new LegalConsumer(txtCompanyName.Text, consumerAddress, _legalFileRepository.GetUnicumId);

                // Определение пути для сохранения файла
                _legalFileRepository.Add(consumer);
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
