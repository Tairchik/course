using System.Windows.Forms;

namespace course.Forms
{
    partial class CreateContractForm
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
            this.labelStartDate = new System.Windows.Forms.Label();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.buttonSaveContract = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonGenerateInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(10, 17);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(129, 13);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "Дата начала контракта:";
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Location = new System.Drawing.Point(165, 14);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(172, 20);
            this.textBoxStartDate.TabIndex = 1;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(10, 52);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(124, 13);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "Дата конца контракта:";
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Location = new System.Drawing.Point(165, 49);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(172, 20);
            this.textBoxEndDate.TabIndex = 3;
            // 
            // buttonSaveContract
            // 
            this.buttonSaveContract.Location = new System.Drawing.Point(13, 87);
            this.buttonSaveContract.Name = "buttonSaveContract";
            this.buttonSaveContract.Size = new System.Drawing.Size(129, 26);
            this.buttonSaveContract.TabIndex = 4;
            this.buttonSaveContract.Text = "Сохранить контракт";
            this.buttonSaveContract.UseVisualStyleBackColor = true;
            this.buttonSaveContract.Click += new System.EventHandler(this.ButtonSaveContract_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(279, 87);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(86, 26);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonGenerateInvoice
            // 
            this.buttonGenerateInvoice.Location = new System.Drawing.Point(146, 87);
            this.buttonGenerateInvoice.Name = "buttonGenerateInvoice";
            this.buttonGenerateInvoice.Size = new System.Drawing.Size(129, 26);
            this.buttonGenerateInvoice.TabIndex = 5;
            this.buttonGenerateInvoice.Text = "Счет клиенту";
            this.buttonGenerateInvoice.UseVisualStyleBackColor = true;
            this.buttonGenerateInvoice.Click += new System.EventHandler(this.ButtonGenerateInvoice_Click);
            // 
            // CreateContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 130);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGenerateInvoice);
            this.Controls.Add(this.buttonSaveContract);
            this.Controls.Add(this.textBoxEndDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.textBoxStartDate);
            this.Controls.Add(this.labelStartDate);
            this.Name = "CreateContractForm";
            this.Text = "Контракт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}