
namespace SUBD_Lab5
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свободныеВакансииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соискателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фирмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вакансииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свободныеВакансииToolStripMenuItem,
            this.соискателиToolStripMenuItem,
            this.фирмыToolStripMenuItem,
            this.вакансииToolStripMenuItem,
            this.сделкиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // свободныеВакансииToolStripMenuItem
            // 
            this.свободныеВакансииToolStripMenuItem.Name = "свободныеВакансииToolStripMenuItem";
            this.свободныеВакансииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.свободныеВакансииToolStripMenuItem.Text = "Сотрудники";
            this.свободныеВакансииToolStripMenuItem.Click += new System.EventHandler(this.свободныеВакансииToolStripMenuItem_Click);
            // 
            // соискателиToolStripMenuItem
            // 
            this.соискателиToolStripMenuItem.Name = "соискателиToolStripMenuItem";
            this.соискателиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.соискателиToolStripMenuItem.Text = "Соискатели";
            this.соискателиToolStripMenuItem.Click += new System.EventHandler(this.соискателиToolStripMenuItem_Click);
            // 
            // фирмыToolStripMenuItem
            // 
            this.фирмыToolStripMenuItem.Name = "фирмыToolStripMenuItem";
            this.фирмыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фирмыToolStripMenuItem.Text = "Фирмы";
            this.фирмыToolStripMenuItem.Click += new System.EventHandler(this.фирмыToolStripMenuItem_Click);
            // 
            // вакансииToolStripMenuItem
            // 
            this.вакансииToolStripMenuItem.Name = "вакансииToolStripMenuItem";
            this.вакансииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вакансииToolStripMenuItem.Text = "Вакансии";
            this.вакансииToolStripMenuItem.Click += new System.EventHandler(this.вакансииToolStripMenuItem_Click);
            // 
            // сделкиToolStripMenuItem
            // 
            this.сделкиToolStripMenuItem.Name = "сделкиToolStripMenuItem";
            this.сделкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сделкиToolStripMenuItem.Text = "Сделки";
            this.сделкиToolStripMenuItem.Click += new System.EventHandler(this.сделкиToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 410);
            this.dataGridView1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Основная форма";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свободныеВакансииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соискателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фирмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вакансииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделкиToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

