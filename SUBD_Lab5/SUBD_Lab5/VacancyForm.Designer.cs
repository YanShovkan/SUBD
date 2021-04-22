
namespace SUBD_Lab5
{
    partial class VacancyForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxFirm = new System.Windows.Forms.ComboBox();
            this.labelFirm = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxSchedule = new System.Windows.Forms.TextBox();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 146);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(278, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 117);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(278, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxFirm
            // 
            this.comboBoxFirm.FormattingEnabled = true;
            this.comboBoxFirm.Location = new System.Drawing.Point(114, 90);
            this.comboBoxFirm.Name = "comboBoxFirm";
            this.comboBoxFirm.Size = new System.Drawing.Size(176, 21);
            this.comboBoxFirm.TabIndex = 24;
            // 
            // labelFirm
            // 
            this.labelFirm.AutoSize = true;
            this.labelFirm.Location = new System.Drawing.Point(9, 93);
            this.labelFirm.Name = "labelFirm";
            this.labelFirm.Size = new System.Drawing.Size(99, 13);
            this.labelFirm.TabIndex = 23;
            this.labelFirm.Text = "Название фирмы:";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(73, 64);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(217, 20);
            this.textBoxSalary.TabIndex = 22;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(9, 67);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(58, 13);
            this.labelSalary.TabIndex = 21;
            this.labelSalary.Text = "Зарплата:";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(83, 38);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(207, 20);
            this.textBoxPosition.TabIndex = 20;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(9, 41);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(68, 13);
            this.labelPosition.TabIndex = 19;
            this.labelPosition.Text = "Должность:";
            // 
            // textBoxSchedule
            // 
            this.textBoxSchedule.Location = new System.Drawing.Point(103, 12);
            this.textBoxSchedule.Name = "textBoxSchedule";
            this.textBoxSchedule.Size = new System.Drawing.Size(187, 20);
            this.textBoxSchedule.TabIndex = 18;
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Location = new System.Drawing.Point(9, 15);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(88, 13);
            this.labelSchedule.TabIndex = 17;
            this.labelSchedule.Text = "График работы:";
            // 
            // VacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 173);
            this.Controls.Add(this.comboBoxFirm);
            this.Controls.Add(this.labelFirm);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.textBoxSchedule);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "VacancyForm";
            this.Text = "Вакансия";
            this.Load += new System.EventHandler(this.VacancyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxFirm;
        private System.Windows.Forms.Label labelFirm;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxSchedule;
        private System.Windows.Forms.Label labelSchedule;
    }
}