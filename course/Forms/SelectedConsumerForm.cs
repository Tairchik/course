using course.interfaces;
using course.Repositories.ClassRepository;
using course.Repositories.InterfacesRepository;
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
    public partial class SelectedConsumerForm : Form
    {
        public SelectedConsumerForm()
        {
            InitializeComponent();
        }
        private void BtnCreateIndividual_Click(object sender, EventArgs e)
        {
            // Открытие формы создания физического лица
            var form = new FormCreateIndividualClient();
            this.Close();
            form.Show();
            
        }

        private void BtnCreateCorporate_Click(object sender, EventArgs e)
        {
            // Открытие формы создания юридического лица
            var form = new FormCreateCorporateClient();
            this.Hide();
            form.Show();
            
        }
    }

}
