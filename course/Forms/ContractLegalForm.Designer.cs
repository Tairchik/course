namespace course.Forms
{
    partial class ContractLegalForm
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
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblNumPeople = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblBuildingNumber = new System.Windows.Forms.Label();
            this.lblNumGuards = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtNumPeople = new System.Windows.Forms.TextBox();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtBuildingNumber = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculateGuards = new System.Windows.Forms.Button();
            this.btnAssignGuards = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(10, 20);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(74, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Дата начала:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(10, 60);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(69, 13);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "Дата конца:";
            // 
            // lblNumPeople
            // 
            this.lblNumPeople.AutoSize = true;
            this.lblNumPeople.Location = new System.Drawing.Point(10, 100);
            this.lblNumPeople.Name = "lblNumPeople";
            this.lblNumPeople.Size = new System.Drawing.Size(162, 13);
            this.lblNumPeople.TabIndex = 4;
            this.lblNumPeople.Text = "Число людей на мероприятии:";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(10, 140);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(99, 13);
            this.lblEventType.TabIndex = 6;
            this.lblEventType.Text = "Тип мероприятия:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(10, 180);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Страна:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(10, 220);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(46, 13);
            this.lblRegion.TabIndex = 10;
            this.lblRegion.Text = "Регион:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(10, 260);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(105, 13);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "Населенный пункт:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(10, 300);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 13);
            this.lblStreet.TabIndex = 14;
            this.lblStreet.Text = "Улица:";
            // 
            // lblBuildingNumber
            // 
            this.lblBuildingNumber.AutoSize = true;
            this.lblBuildingNumber.Location = new System.Drawing.Point(10, 340);
            this.lblBuildingNumber.Name = "lblBuildingNumber";
            this.lblBuildingNumber.Size = new System.Drawing.Size(94, 13);
            this.lblBuildingNumber.TabIndex = 16;
            this.lblBuildingNumber.Text = "Номер строения:";
            // 
            // lblNumGuards
            // 
            this.lblNumGuards.AutoSize = true;
            this.lblNumGuards.Location = new System.Drawing.Point(441, 14);
            this.lblNumGuards.Name = "lblNumGuards";
            this.lblNumGuards.Size = new System.Drawing.Size(104, 13);
            this.lblNumGuards.TabIndex = 18;
            this.lblNumGuards.Text = "Число охранников:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(200, 20);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(200, 20);
            this.txtStartDate.TabIndex = 1;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(200, 60);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(200, 20);
            this.txtEndDate.TabIndex = 3;
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.Location = new System.Drawing.Point(200, 100);
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Size = new System.Drawing.Size(200, 20);
            this.txtNumPeople.TabIndex = 5;
            // 
            // cmbEventType
            // 
            this.cmbEventType.Items.AddRange(new object[] {
            "Общественный",
            "Частный",
            "Индивидуальный"});
            this.cmbEventType.Location = new System.Drawing.Point(200, 140);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(200, 21);
            this.cmbEventType.TabIndex = 7;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(200, 180);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(200, 20);
            this.txtCountry.TabIndex = 9;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(200, 220);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(200, 20);
            this.txtRegion.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(200, 260);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 20);
            this.txtCity.TabIndex = 13;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(200, 300);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(200, 20);
            this.txtStreet.TabIndex = 15;
            // 
            // txtBuildingNumber
            // 
            this.txtBuildingNumber.Location = new System.Drawing.Point(200, 340);
            this.txtBuildingNumber.Name = "txtBuildingNumber";
            this.txtBuildingNumber.Size = new System.Drawing.Size(200, 20);
            this.txtBuildingNumber.TabIndex = 17;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(441, 36);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(197, 20);
            this.txtEventName.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(540, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Выйти";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnCalculateGuards
            // 
            this.btnCalculateGuards.Location = new System.Drawing.Point(438, 62);
            this.btnCalculateGuards.Name = "btnCalculateGuards";
            this.btnCalculateGuards.Size = new System.Drawing.Size(200, 30);
            this.btnCalculateGuards.TabIndex = 21;
            this.btnCalculateGuards.Text = "Рассчитать число охранников";
            this.btnCalculateGuards.Click += new System.EventHandler(this.BtnCalculateGuards_Click);
            // 
            // btnAssignGuards
            // 
            this.btnAssignGuards.Location = new System.Drawing.Point(438, 100);
            this.btnAssignGuards.Name = "btnAssignGuards";
            this.btnAssignGuards.Size = new System.Drawing.Size(200, 30);
            this.btnAssignGuards.TabIndex = 22;
            this.btnAssignGuards.Text = "Назначить охранников";
            this.btnAssignGuards.Click += new System.EventHandler(this.BtnAssignGuards_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CreateIndividualEventForm
            // 
            this.ClientSize = new System.Drawing.Size(652, 500);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.lblNumPeople);
            this.Controls.Add(this.txtNumPeople);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.cmbEventType);
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
            this.Controls.Add(this.lblNumGuards);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateGuards);
            this.Controls.Add(this.btnAssignGuards);
            this.Name = "CreateIndividualEventForm";
            this.Text = "Создание Индивидуального Мероприятия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}