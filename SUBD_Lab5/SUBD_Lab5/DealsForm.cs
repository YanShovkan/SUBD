using Logic.BindingModels;
using Logic.Logic;
using System;
using System.Windows.Forms;
using Unity;

namespace SUBD_Lab5
{
    public partial class DealsForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly DealLogic logic;
        public DealsForm(DealLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void LoadData()
        {
            try
            {
                var list = logic.Read(null);
                if (list != null)
                {
                    dataGridViewDeals.DataSource = list;
                    dataGridViewDeals.Columns[0].Visible = false;
                    dataGridViewDeals.Columns[1].Visible = false;
                    dataGridViewDeals.Columns[2].Visible = false;
                    dataGridViewDeals.Columns[3].Visible = false;
                    dataGridViewDeals.Columns[4].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void DealsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<DealForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeals.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<DealForm>();
                form.Id = Convert.ToInt32(dataGridViewDeals.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeals.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridViewDeals.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        logic.Delete(new DealBM { Id = id });
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
