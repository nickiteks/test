using bussines.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormPapers : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IPaperLogic logic;
        public FormPapers(IPaperLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAddPaper>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            try
            {
                Program.ConfigGrid(logic.Read(null), dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormPapers_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
