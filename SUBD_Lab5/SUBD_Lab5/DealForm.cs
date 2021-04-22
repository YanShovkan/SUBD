using System;
using System.Collections.Generic;
using System.ComponentModel;
using Logic.BindingModels;
using Logic.ViewModels;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class DealForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly VacancyLogic Vlogic;
        private readonly EmployeeLogic Elogic;
        private readonly AppliacntLogic Alogic;
        private readonly DealLogic Dlogic;
        private int? id;
        public DealForm(VacancyLogic Vlogic, EmployeeLogic Elogic, AppliacntLogic Alogic, DealLogic Dlogic)
        {
            InitializeComponent();
            this.Vlogic = Vlogic;
            this.Elogic = Elogic;
            this.Alogic = Alogic;
            this.Dlogic = Dlogic;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dateTimePickerDate.Value >= DateTime.Now || dateTimePickerDate.Value == null)
            {
                MessageBox.Show("Выберите дату заключения сделки", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxEmployee.SelectedItem == null)
            {
                MessageBox.Show("Выберите сотрудника", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxApplicant.SelectedItem == null)
            {
                MessageBox.Show("Выберите соискателя", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxVacancy.SelectedItem == null)
            {
                MessageBox.Show("Выберите вакансию", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                Dlogic.CreateOrUpdate(new DealBM
                {
                    Id = id,
                    Date = dateTimePickerDate.Value,
                    EmployeeId = Convert.ToInt32(comboBoxEmployee.SelectedValue),
                    ApplicantId = Convert.ToInt32(comboBoxApplicant.SelectedValue),
                    VacancyId = Convert.ToInt32(comboBoxVacancy.SelectedValue)
                });
                Vlogic.UpdateEmployment(new VacancyBM
                {
                    Id = Convert.ToInt32(comboBoxVacancy.SelectedValue),
                });
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

        private void DealForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<EmployeeVM> Elist = Elogic.Read(null);
                if (Elist != null)
                {
                    comboBoxEmployee.DisplayMember = "Surname";
                    comboBoxEmployee.ValueMember = "Id";
                    comboBoxEmployee.DataSource = Elist;
                    comboBoxEmployee.SelectedItem = null;
                }
                List<ApplicantVM> Alist = Alogic.Read(null);
                if (Alist != null)
                {
                    comboBoxApplicant.DisplayMember = "Surname";
                    comboBoxApplicant.ValueMember = "Id";
                    comboBoxApplicant.DataSource = Alist;
                    comboBoxApplicant.SelectedItem = null;
                }
                List<VacancyVM> Vlist = Vlogic.Read(new VacancyBM { Employment = false}) ;
                if (Vlist != null)
                {
                    comboBoxVacancy.DisplayMember = "Position";
                    comboBoxVacancy.ValueMember = "Id";
                    comboBoxVacancy.DataSource = Vlist;
                    comboBoxVacancy.SelectedItem = null;
                }
                if (id.HasValue)
                {
                    var view = Dlogic.Read(new DealBM { Id = id })?[0];
                    if (view != null)
                    {
                        dateTimePickerDate.Value = view.Date;

                        EmployeeVM employee = Elogic.Read(new EmployeeBM { Id = view.EmployeeId })?[0];
                        foreach (var currentEmployee in Elist)
                        {
                            if (currentEmployee.Id == employee.Id)
                            {
                                comboBoxEmployee.SelectedItem = currentEmployee;
                            }
                        }

                        ApplicantVM applicant = Alogic.Read(new ApplicantBM { Id = view.ApplicantId })?[0];
                        foreach (var currentApplicant in Alist)
                        {
                            if (currentApplicant.Id == applicant.Id)
                            {
                                comboBoxApplicant.SelectedItem = currentApplicant;
                            }
                        }
                        Vlist = Vlogic.Read(new VacancyBM { Employment = true });
                        
                        VacancyVM vacancy = Vlogic.Read(new VacancyBM { Id = view.VacancyId })?[0];
                        foreach (var currentVacancy in Vlist)
                        {
                            if (currentVacancy.Id == vacancy.Id)
                            {
                                comboBoxVacancy.SelectedItem = currentVacancy;
                            }
                        }
                        Vlist = Vlogic.Read(new VacancyBM { Employment = false });
                        if (Elist != null)
                        {
                            comboBoxVacancy.DisplayMember = "Position";
                            comboBoxVacancy.ValueMember = "Id";
                            comboBoxVacancy.DataSource = Vlist;
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

