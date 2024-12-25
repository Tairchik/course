using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Опция 1",
            "Опция 2",
            "Опция 3"});
            this.comboBox.Location = new System.Drawing.Point(12, 20);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(200, 23);
            this.comboBox.TabIndex = 0;

            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(230, 20);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 30);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);

            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(340, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);

            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(450, 20);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 30);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 80);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Форма с выпадающим списком и кнопками";
            this.ResumeLayout(false);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы выбрали: {comboBox.SelectedItem}");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem != null)
                MessageBox.Show($"Редактирование: {comboBox.SelectedItem}");
            else
                MessageBox.Show("Выберите элемент для редактирования.");
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создание новой записи...");
        }

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
    }
}