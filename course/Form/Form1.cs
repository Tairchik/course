using course.Controllers;
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

namespace course
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
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
            if (listBox.SelectedItem != null)
                MessageBox.Show($"Редактирование: {listBox.SelectedItem}");
            else
                MessageBox.Show("Пожалуйста, выберите элемент для редактирования.");
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string newItem = $"Элемент {listBox.Items.Count + 1}";
            listBox.Items.Add(newItem);
            MessageBox.Show($"Создан новый элемент: {newItem}");
        }
        private void UpdateSavesList()
        {
            listBox.DataSource = null;
 
        }
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
    }
}