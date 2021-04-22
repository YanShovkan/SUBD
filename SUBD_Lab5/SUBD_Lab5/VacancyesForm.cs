using Logic.BindingModels;
using Logic.Logic;
using System;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class VacancyesForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly VacancyLogic logic;
        public VacancyesForm(VacancyLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void LoadData()
        {
            try
            {
                var listBusy = logic.Read(new VacancyBM{ Employment = true} );
                if (listBusy != null)
                {
                    dataGridViewBusyVacancyes.DataSource = listBusy;
                    dataGridViewBusyVacancyes.Columns[0].Visible = false;
                    dataGridViewBusyVacancyes.Columns[1].Visible = false;
                    dataGridViewBusyVacancyes.Columns[2].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
                var listFree = logic.Read(new VacancyBM { Employment = false });
                if (listFree != null)
                {
                    dataGridViewFreeVacancyes.DataSource = listFree;
                    dataGridViewFreeVacancyes.Columns[0].Visible = false;
                    dataGridViewFreeVacancyes.Columns[1].Visible = false;
                    dataGridViewFreeVacancyes.Columns[2].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<VacancyForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBusyVacancyes.SelectedRows.Count == 1 || dataGridViewFreeVacancyes.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id;
                    if (dataGridViewBusyVacancyes.SelectedRows.Count == 1)
                    {
                        id = Convert.ToInt32(dataGridViewBusyVacancyes.SelectedRows[0].Cells[0].Value);
                    }
                    else
                    {
                        id = Convert.ToInt32(dataGridViewFreeVacancyes.SelectedRows[0].Cells[0].Value);
                    } 
                    try
                    {
                        logic.Delete(new VacancyBM { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBusyVacancyes.SelectedRows.Count == 1 || dataGridViewFreeVacancyes.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<VacancyForm>();
                if (dataGridViewBusyVacancyes.SelectedRows.Count == 1)
                {
                    form.Id = Convert.ToInt32(dataGridViewBusyVacancyes.SelectedRows[0].Cells[0].Value);
                }
                else
                {
                    form.Id = Convert.ToInt32(dataGridViewFreeVacancyes.SelectedRows[0].Cells[0].Value);
                }
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void VacancyesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewBusyVacancyes_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewFreeVacancyes.ClearSelection();
        }

        private void dataGridViewFreeVacancyes_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewBusyVacancyes.ClearSelection();
        }
    }
}
