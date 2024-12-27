namespace course.Forms
{
    partial class EditLegalConsumerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblBuildingNumber = new System.Windows.Forms.Label();
            this.txtBuildingNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(9, 17);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(113, 13);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Название компании:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(129, 17);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(172, 20);
            this.txtCompanyName.TabIndex = 1;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(9, 52);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Страна:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(129, 52);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(172, 20);
            this.txtCountry.TabIndex = 3;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(9, 87);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(46, 13);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "Регион:";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(129, 87);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(172, 20);
            this.txtRegion.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(9, 121);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(105, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Населенный пункт:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(129, 121);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(172, 20);
            this.txtCity.TabIndex = 7;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(9, 156);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 13);
            this.lblStreet.TabIndex = 8;
            this.lblStreet.Text = "Улица:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(129, 156);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(172, 20);
            this.txtStreet.TabIndex = 9;
            // 
            // lblBuildingNumber
            // 
            this.lblBuildingNumber.AutoSize = true;
            this.lblBuildingNumber.Location = new System.Drawing.Point(9, 191);
            this.lblBuildingNumber.Name = "lblBuildingNumber";
            this.lblBuildingNumber.Size = new System.Drawing.Size(94, 13);
            this.lblBuildingNumber.TabIndex = 10;
            this.lblBuildingNumber.Text = "Номер строения:";
            // 
            // txtBuildingNumber
            // 
            this.txtBuildingNumber.Location = new System.Drawing.Point(129, 191);
            this.txtBuildingNumber.Name = "txtBuildingNumber";
            this.txtBuildingNumber.Size = new System.Drawing.Size(172, 20);
            this.txtBuildingNumber.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 26);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(103, 225);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(129, 26);
            this.btnBackToMenu.TabIndex = 13;
            this.btnBackToMenu.Text = "Вернуться в меню";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.BtnBackToMenu_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(289, 232);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.Text = "ID:";
            // 
            // lblIdText
            // 
            this.lblIdText.AutoSize = true;
            this.lblIdText.Location = new System.Drawing.Point(305, 232);
            this.lblIdText.Name = "lblIdText";
            this.lblIdText.Size = new System.Drawing.Size(21, 13);
            // 
            // EditLegalConsumerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 277);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblBuildingNumber);
            this.Controls.Add(this.txtBuildingNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblIdText);
            this.Name = "EditLegalConsumerForm";
            this.Text = "Изменение юридического заказчика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}