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
    public partial class CreateContractForm : Form
    {

        const string directoryPath = "..\\..\\Data\\DataContract";
        private IContract contract;
        private readonly ContractsRepository contractsRepository = new ContractsRepository(directoryPath);


        public CreateContractForm(int ContractID)
        {
            InitializeComponent();
            contract = contractsRepository.GetById(ContractID);
        }

        private void ButtonSaveContract_Click(object sender, EventArgs e)
        {
            if (textBoxStartDate.Text != null && textBoxEndDate.Text != null)
            {
                try
                {
                    contract.DateStartContract = DateTime.Parse(textBoxStartDate.Text);
                    contract.DateEndContract = DateTime.Parse(textBoxEndDate.Text);
                    contractsRepository.Update(contract);
                    ManagerForm managerForm = new ManagerForm();
                    managerForm.Show();
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Ошибка пустые поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonGenerateInvoice_Click(object sender, EventArgs e)
        {
            //
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Label labelStartDate;
        private TextBox textBoxStartDate;
        private Label labelEndDate;
        private TextBox textBoxEndDate;
        private Button buttonSaveContract;
        private Button buttonExit;
        private Button buttonGenerateInvoice;
    }
}
