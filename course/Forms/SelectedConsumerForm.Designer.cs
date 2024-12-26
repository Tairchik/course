namespace course.Forms
{
    partial class SelectedConsumerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCreateIndividual = new System.Windows.Forms.Button();
            this.btnCreateCorporate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnCreateIndividual
            // 
            this.btnCreateIndividual.Location = new System.Drawing.Point(50, 30);
            this.btnCreateIndividual.Name = "btnCreateIndividual";
            this.btnCreateIndividual.Size = new System.Drawing.Size(200, 40);
            this.btnCreateIndividual.TabIndex = 0;
            this.btnCreateIndividual.Text = "Создать физическое лицо";
            this.btnCreateIndividual.UseVisualStyleBackColor = true;
            this.btnCreateIndividual.Click += new System.EventHandler(this.BtnCreateIndividual_Click);

            // 
            // btnCreateCorporate
            // 
            this.btnCreateCorporate.Location = new System.Drawing.Point(50, 90);
            this.btnCreateCorporate.Name = "btnCreateCorporate";
            this.btnCreateCorporate.Size = new System.Drawing.Size(200, 40);
            this.btnCreateCorporate.TabIndex = 1;
            this.btnCreateCorporate.Text = "Создать юридическое лицо";
            this.btnCreateCorporate.UseVisualStyleBackColor = true;
            this.btnCreateCorporate.Click += new System.EventHandler(this.BtnCreateCorporate_Click);

            // 
            // FormSelectClientType
            // 
            this.ClientSize = new System.Drawing.Size(300, 160);
            this.Controls.Add(this.btnCreateCorporate);
            this.Controls.Add(this.btnCreateIndividual);
            this.Name = "FormSelectClientType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор типа клиента";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCreateIndividual;
        private System.Windows.Forms.Button btnCreateCorporate;
    }
}

