using bussines.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormStudents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IStudentLogic studentLogic;
        public FormStudents(IStudentLogic studentLogic)
        {
            InitializeComponent();
            this.studentLogic = studentLogic;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAddStudent>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void FormAutor_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                Program.ConfigGrid(studentLogic.Read(null), dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
