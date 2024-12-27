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
        const string path = "..\\..\\Data\\DataWorker\\DataSecurity";
        private SecuritiesJsonRepository securitiesJsonRepository = new SecuritiesJsonRepository(path);
        private DateTime dateStart;
        private DateTime dateEnd;
        public SecurityAddForm(DateTime dateEnd, DateTime dateStart)
        {
            InitializeComponent();
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            LoadFilesIntoListBox();
        }

        private void LoadFilesIntoListBox()
        {
            try
            {
                List<Security> files = securitiesJsonRepository.GetAll()
                    .Cast<Security>()
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
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите элемент для удаления графика.");
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
                    for (int day = 0; day <= (dateEnd - dateEnd).Days; day++) 
                    {
                        schedule.Add(dateStart.AddDays(day));
                    }
                    security.Schedule = schedule;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка загрузки файлов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
                

            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
