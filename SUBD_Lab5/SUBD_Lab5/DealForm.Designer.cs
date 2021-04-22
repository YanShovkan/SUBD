
namespace SUBD_Lab5
{
    partial class DealForm
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
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxApplicant = new System.Windows.Forms.ComboBox();
            this.labelApplicant = new System.Windows.Forms.Label();
            this.comboBoxVacancy = new System.Windows.Forms.ComboBox();
            this.labelVacancy = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(77, 32);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(216, 21);
            this.comboBoxEmployee.TabIndex = 30;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(12, 35);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(63, 13);
            this.labelEmployee.TabIndex = 29;
            this.labelEmployee.Text = "Сотрудник:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(100, 13);
            this.labelDate.TabIndex = 27;
            this.labelDate.Text = "Дата заключения:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(15, 142);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(278, 23);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(15, 113);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(278, 23);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxApplicant
            // 
            this.comboBoxApplicant.FormattingEnabled = true;
            this.comboBoxApplicant.Location = new System.Drawing.Point(88, 59);
            this.comboBoxApplicant.Name = "comboBoxApplicant";
            this.comboBoxApplicant.Size = new System.Drawing.Size(205, 21);
            this.comboBoxApplicant.TabIndex = 32;
            // 
            // labelApplicant
            // 
            this.labelApplicant.AutoSize = true;
            this.labelApplicant.Location = new System.Drawing.Point(12, 62);
            this.labelApplicant.Name = "labelApplicant";
            this.labelApplicant.Size = new System.Drawing.Size(70, 13);
            this.labelApplicant.TabIndex = 31;
            this.labelApplicant.Text = "Соискатель:";
            // 
            // comboBoxVacancy
            // 
            this.comboBoxVacancy.FormattingEnabled = true;
            this.comboBoxVacancy.Location = new System.Drawing.Point(77, 86);
            this.comboBoxVacancy.Name = "comboBoxVacancy";
            this.comboBoxVacancy.Size = new System.Drawing.Size(216, 21);
            this.comboBoxVacancy.TabIndex = 34;
            // 
            // labelVacancy
            // 
            this.labelVacancy.AutoSize = true;
            this.labelVacancy.Location = new System.Drawing.Point(12, 89);
            this.labelVacancy.Name = "labelVacancy";
            this.labelVacancy.Size = new System.Drawing.Size(59, 13);
            this.labelVacancy.TabIndex = 33;
            this.labelVacancy.Text = "Вакансия:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(117, 9);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerDate.TabIndex = 35;
            // 
            // DealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 177);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.comboBoxVacancy);
            this.Controls.Add(this.labelVacancy);
            this.Controls.Add(this.comboBoxApplicant);
            this.Controls.Add(this.labelApplicant);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "DealForm";
            this.Text = "DealForm";
            this.Load += new System.EventHandler(this.DealForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxApplicant;
        private System.Windows.Forms.Label labelApplicant;
        private System.Windows.Forms.ComboBox comboBoxVacancy;
        private System.Windows.Forms.Label labelVacancy;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
    }
}