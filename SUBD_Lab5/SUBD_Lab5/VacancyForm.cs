using Logic.BindingModels;
using Logic.ViewModels;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class VacancyForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly VacancyLogic Vlogic;
        private readonly FirmLogic Flogic;
        private int? id;
        public VacancyForm(VacancyLogic Vlogic, FirmLogic Flogic)
        {
            InitializeComponent();
            this.Vlogic = Vlogic;
            this.Flogic = Flogic;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSchedule.Text))
            {
                MessageBox.Show("Введите шрафик работы", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPosition.Text))
            {
                MessageBox.Show("Введите должность", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxSalary.Text))
            {
                MessageBox.Show("Введите зарплату", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxFirm.SelectedValue == null)
            {
                MessageBox.Show("Выберите фирму", "Ошибка", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
                return;
            }
            try
            {
                VacancyVM currentVacancy = Vlogic.Read(new VacancyBM { Id = id })[0];
                VacancyBM vacancy = new VacancyBM
                {
                    Id = id,
                    Schedule = textBoxSchedule.Text,
                    Position = textBoxPosition.Text,
                    Salary = Convert.ToInt32(textBoxSalary.Text),
                    FirmId = Convert.ToInt32(comboBoxFirm.SelectedValue),
                };

                if (currentVacancy != null)
                {
                    vacancy.Employment = currentVacancy.Employment;
                }
                else
                {
                    vacancy.Employment = false;
                }
                Vlogic.CreateOrUpdate(vacancy);
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void VacancyForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<FirmVM> list = Flogic.Read(null);
                if (list != null)
                {
                    comboBoxFirm.DisplayMember = "Name";
                    comboBoxFirm.ValueMember = "Id";
                    comboBoxFirm.DataSource = list;
                    comboBoxFirm.SelectedItem = null;
                }
                if (id.HasValue)
                {
                    var view = Vlogic.Read(new VacancyBM { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxSchedule.Text = view.Schedule;
                        textBoxPosition.Text = view.Position;
                        textBoxSalary.Text = view.Salary.ToString();
                        FirmVM firm = Flogic.Read(new FirmBM { Name = view.FirmName })?[0]; 
                        foreach (var currentFirm in list)
                        {
                            if (currentFirm.Name == firm.Name)
                            {
                                comboBoxFirm.SelectedItem = currentFirm;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
