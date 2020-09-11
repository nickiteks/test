using bussines.BindingModels;
using bussines.Interfaces;
using bussines.ViewModels;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormAddStudent : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IGroupLogic logicG;
        private readonly IStudentLogic logicS;
        public FormAddStudent(IGroupLogic logicG, IStudentLogic logicS)
        {
            InitializeComponent();
            this.logicG = logicG;
            this.logicS = logicS;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]{2}$");
            if(!regex.IsMatch(textBoxPassingScore.Text)){
                MessageBox.Show("Некоректно введен проходной бал", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                logicS.CreateOrUpdate(new StudentBindingModel
                {
                    FIO = textBoxName.Text,
                    GroupId = Convert.ToInt32(ComboBoxGroup.SelectedValue),
                    PassingScore =Convert.ToInt32(textBoxPassingScore.Text),
                    DateOfCrediting = DateTime.Now,
                    RecordBook = Convert.ToInt32(textBoxRecordBook.Text),
                });;
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

        private void FormAddAutor_Load(object sender, EventArgs e)
        {
            try
            {
                var list = logicG.Read(null);
                if (list != null)
                {
                    ComboBoxGroup.DisplayMember = "Name";
                    ComboBoxGroup.ValueMember = "id";
                    ComboBoxGroup.DataSource = list;
                    ComboBoxGroup.SelectedItem = null;
                }
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
    }
}
