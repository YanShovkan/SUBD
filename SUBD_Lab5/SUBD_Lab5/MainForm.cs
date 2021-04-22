using System.Collections.Generic;
using System.ComponentModel;
using Logic.BindingModels;
using Logic.Logic;
using Logic.ViewModels;
using System;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void фирмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FirmsForm>();
            form.ShowDialog();
        }

        private void соискателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<ApplicantsForm>();
            form.ShowDialog();
        }

        private void свободныеВакансииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<EmployeesForm>();
            form.ShowDialog();
        }

        private void вакансииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<VacancyesForm>();
            form.ShowDialog();
        }

        private void сделкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<DealsForm>();
            form.ShowDialog();
        }
    }
}
