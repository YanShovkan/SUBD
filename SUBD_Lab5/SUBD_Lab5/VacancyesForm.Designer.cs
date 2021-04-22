
namespace SUBD_Lab5
{
    partial class VacancyesForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewBusyVacancyes = new System.Windows.Forms.DataGridView();
            this.dataGridViewFreeVacancyes = new System.Windows.Forms.DataGridView();
            this.labelFree = new System.Windows.Forms.Label();
            this.labelBusy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusyVacancyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeVacancyes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(631, 168);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(157, 46);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(631, 116);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(157, 46);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(631, 64);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(157, 46);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(631, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(157, 46);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewBusyVacancyes
            // 
            this.dataGridViewBusyVacancyes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBusyVacancyes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusyVacancyes.Location = new System.Drawing.Point(12, 15);
            this.dataGridViewBusyVacancyes.Name = "dataGridViewBusyVacancyes";
            this.dataGridViewBusyVacancyes.Size = new System.Drawing.Size(613, 202);
            this.dataGridViewBusyVacancyes.TabIndex = 15;
            this.dataGridViewBusyVacancyes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBusyVacancyes_CellContentClick);
            // 
            // dataGridViewFreeVacancyes
            // 
            this.dataGridViewFreeVacancyes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFreeVacancyes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFreeVacancyes.Location = new System.Drawing.Point(12, 236);
            this.dataGridViewFreeVacancyes.Name = "dataGridViewFreeVacancyes";
            this.dataGridViewFreeVacancyes.Size = new System.Drawing.Size(613, 202);
            this.dataGridViewFreeVacancyes.TabIndex = 20;
            this.dataGridViewFreeVacancyes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFreeVacancyes_CellContentClick);
            // 
            // labelFree
            // 
            this.labelFree.AutoSize = true;
            this.labelFree.Location = new System.Drawing.Point(12, 220);
            this.labelFree.Name = "labelFree";
            this.labelFree.Size = new System.Drawing.Size(118, 13);
            this.labelFree.TabIndex = 21;
            this.labelFree.Text = "Доступные вакансии:";
            // 
            // labelBusy
            // 
            this.labelBusy.AutoSize = true;
            this.labelBusy.Location = new System.Drawing.Point(12, -1);
            this.labelBusy.Name = "labelBusy";
            this.labelBusy.Size = new System.Drawing.Size(148, 13);
            this.labelBusy.TabIndex = 22;
            this.labelBusy.Text = "Распределенные вакансии:";
            // 
            // VacancyesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBusy);
            this.Controls.Add(this.labelFree);
            this.Controls.Add(this.dataGridViewFreeVacancyes);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewBusyVacancyes);
            this.Name = "VacancyesForm";
            this.Text = "Вакансии";
            this.Load += new System.EventHandler(this.VacancyesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusyVacancyes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeVacancyes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewBusyVacancyes;
        private System.Windows.Forms.DataGridView dataGridViewFreeVacancyes;
        private System.Windows.Forms.Label labelFree;
        private System.Windows.Forms.Label labelBusy;
    }
}