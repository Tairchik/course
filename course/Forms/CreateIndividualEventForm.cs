using course.Entities.classes;
using course;
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
using course.Entities;

namespace course.Forms
{
    public partial class CreateIndividualEventForm : Form
    {
      
        private IIndividualConsumer consumer;
        private ISingleEvent singleEvent;
        private List<ISecurity> securities;

        const string directoryPath = "..\\..\\Data\\DataContract";
        const string directoryIndividualPath = "..\\..\\Data\\DataConsumer\\DataIndividual";
        const string directorySecurity = "..\\..\\Data\\DataWorker\\DataSecurity";

        private readonly ContractsRepository contractsRepository = new ContractsRepository(directoryPath);
        private readonly IndividualConsumerJsonRepository _individualFileRepository = new IndividualConsumerJsonRepository(directoryIndividualPath);
        private readonly SecuritiesJsonRepository securityRepository = new SecuritiesJsonRepository(directorySecurity);

        // Обработчик события
        private void Form_GuardsAssigned(object sender, List<int> idSecurities)
        {
            // Обрабатываем полученные данные (например, сохраняем их в SingleEvent или другом объекте)
            if (singleEvent != null)
            {
                List<ISecurity> securities = new List<ISecurity>();
                foreach (int idSecurity in idSecurities) 
                {
                    securities.Add(securityRepository.GetById(idSecurity));
                }
                this.securities = securities; // Допустим, у SingleEvent есть поле AssignedGuards
            }
        }
        public CreateIndividualEventForm(int idConsumer)
        {
            try
            {
                this.consumer = _individualFileRepository.GetById(idConsumer);
                InitializeComponent();
                AddToComboBoxEnums();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private EventType ReturnSelectComboBox()
        {
            if (cmbEventType.SelectedItem == null)
            {
                MessageBox.Show($"Не выбран тип мероприятия", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return EventType.Public;
            }
            else if (cmbEventType.SelectedItem.ToString() == EventType.Public.ToString())
            {
                return EventType.Public;
            }
            else if (cmbEventType.SelectedItem.ToString() == EventType.Personal.ToString())
            {
                return EventType.Private;
            }
            else 
            {
                return EventType.Personal;
            }
         
        }
        private void AddToComboBoxEnums()
        {
            cmbEventType.Items.Clear();
            foreach (var eventType in Enum.GetValues(typeof(EventType)))
            {
                cmbEventType.Items.Add(eventType);
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                InitSingleEvent();
                IContract contract1 = new ContractClass(contractsRepository.GetUnicumId, DateTime.Now, DateTime.Parse(txtEndDate.Text), singleEvent);
                contract1.Securities = this.securities;
                consumer.AddContract(contract1);

                

                _individualFileRepository.Update(consumer);
                //CreateContractForm form = new CreateContractForm(contract.ID);
                //form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitSingleEvent()
        {
            try
            {
                IAddress eventAddress = new AddressRU(txtCountry.Text, txtRegion.Text, txtCity.Text, txtStreet.Text, txtBuildingNumber.Text);
                singleEvent = new SingleEvent(eventAddress, DateTime.Parse(txtStartDate.Text), DateTime.Parse(txtEndDate.Text), ReturnSelectComboBox(), int.Parse(txtNumPeople.Text), new CalculateTotalAmountSingleEvent());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCalculateGuards_Click(object sender, EventArgs e)
        {
            CalculateTotalAmountSingleEvent calculator = new CalculateTotalAmountSingleEvent();
            InitSingleEvent();
            try
            {
                if (singleEvent != null) 
                {
                    int totalAmountSecurity = singleEvent.CalculateAmount();
                    txtEventName.Text = totalAmountSecurity.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при расчете числа охранников: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnAssignGuards_Click(object sender, EventArgs e)
        {
            InitSingleEvent();
            try
            {
                // Создаем дочернюю форму и подписываемся на событие
                SecurityAddForm form = new SecurityAddForm(singleEvent.DateEnd, singleEvent.DateStart, singleEvent.CalculateAmount());
                form.GuardsAssigned += Form_GuardsAssigned; // Подписка на событие

                form.ShowDialog(); // Используем ShowDialog, чтобы дождаться завершения
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblNumPeople;
        private Label lblEventType;
        private Label lblCountry;
        private Label lblRegion;
        private Label lblCity;
        private Label lblStreet;
        private Label lblBuildingNumber;

        private Label lblNumGuards;

        private TextBox txtStartDate;
        private TextBox txtEndDate;
        private TextBox txtNumPeople;
        private ComboBox cmbEventType;
        private TextBox txtCountry;
        private TextBox txtRegion;
        private TextBox txtCity;
        private TextBox txtStreet;
        private TextBox txtBuildingNumber;

        private Button btnSave;
        private Button btnExit;
        private Button btnCalculateGuards;
        private Button btnAssignGuards;

   
    }
}
