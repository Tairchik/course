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
    public partial class SecurityAddForm : Form
    {
        public event EventHandler<List<int>> GuardsAssigned; // Событие для передачи данных

        const string path = "..\\..\\Data\\DataWorker\\DataSecurity";
        private SecuritiesJsonRepository securitiesJsonRepository = new SecuritiesJsonRepository(path);
        private DateTime dateStart;
        private DateTime dateEnd;
        private List<int> listOfId = new List<int> { };
        private int numOfSecurity;
        public SecurityAddForm(DateTime dateEnd, DateTime dateStart, int numOfSecurity)
        {
            InitializeComponent();
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.numOfSecurity = numOfSecurity; 
            LoadFilesIntoListBox();
        }

        private void LoadFilesIntoListBox()
        {
            try
            {
                List<ISecurity> files = securitiesJsonRepository.GetAll()
                    .Cast<ISecurity>()
                    .ToList();
     
                listBox.Items.Clear();

                foreach (var file in files)
                {
                    listBox.Items.Add(file.Name + " " + file.Surname + " " + file.Patronymic + "-" + file.Id.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка загрузки файлов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnRemove_Click(object sender, EventArgs e) // Назначить охранника
        {
            if (listBox.SelectedItem != null)
            {
              
                int select = int.Parse(listBox.SelectedItem.ToString().Split('-')[1]);
                ISecurity security = securitiesJsonRepository.GetById(select);
                try
                {
                    ISchedule schedule = new Schedule();
                    if (security.Schedule != null)
                    {
                        schedule = security.Schedule;
                    }


                    for (int day = 0; day <= (dateEnd - dateEnd).Days; day++)
                    {
                        schedule.DeleteDay(dateStart.AddDays(day));
                    }
                    security.Schedule = schedule;
                    listOfId.Remove(security.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка загрузки файлов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Ошибка: выберете элемент", "Ошибка загрузки файлов", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void BtnSelect_Click(object sender, EventArgs e) // Назначить охранника
        {
            
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите элемент для назначения графика.");
            }
            else
            {
                int select = int.Parse(listBox.SelectedItem.ToString().Split('-')[1]);
                ISecurity security = securitiesJsonRepository.GetById(select);
                try
                {
                    ISchedule schedule = new Schedule();
                    if(security.Schedule != null)
                    {
                        schedule = security.Schedule;
                    }

                    for (int day = 0; day <= (dateEnd - dateEnd).Days; day++) 
                    {
                        schedule.Add(dateStart.AddDays(day));
                     
                    }
                    security.Schedule = schedule;
                    listOfId.Add(security.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка загрузки файлов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (listOfId.Count < numOfSecurity)
            {
                MessageBox.Show($"Ошибка: требуется еще {numOfSecurity - listOfId.Count} охранников(к)", "Ошибка сохранения графики охранникам", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                // Вызываем событие для передачи данных в родительскую форму
                GuardsAssigned?.Invoke(this, listOfId);

                // Закрываем форму
                this.Close();
            }
        }
    }
}
