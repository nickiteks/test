using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class FormTest : Form
    {
        string[] values = { "Значение 1", "Значение 2", "Значение 3", "Значение 4", "Значение 5" };
        Class1 cl = new Class1();
        public FormTest()
        {
            InitializeComponent();
            controlComboBoxSelected.LoadEnumeration(typeof(TestEnum));
            foreach(string str in values)
            {
                controlListBox.Items.Add(str);
            }
            controlPhoneNumberCheck.setColor = Color.Red;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            controlComboBoxSelected.SelectedIndex = 0;
        }

        private void controlComboBoxSelected1_ComboBoxSelectedElementChange(object sender, EventArgs e)
        {        
            MessageBox.Show(controlComboBoxSelected.SelectedText);
        }

        private void controlListBox1_ComboBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(controlListBox.SelectedText);
        }

        private void controlPhoneNumberCheck_NumberWrite(object sender, EventArgs e)
        {
            if(controlPhoneNumberCheck.GetNumber()!= "")
            {
                MessageBox.Show(controlPhoneNumberCheck.GetNumber());
            }
        }

        private void controlListOfValues_ListBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(controlListOfValues.SelectedText);
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            controlListOfValues.SetMainLine = textBoxMainString.Text;
            controlListOfValues.GetProperty(cl);
        }

        private void buttonCH_Click(object sender, EventArgs e)
        {
            controlListOfValues.SetChangeValue = textBoxChange.Text;
            cl = new Class1();
            cl.SelectedValue = 100;
            controlListOfValues.ChangeListValue(cl,"SelectedValue",3);
        }
    }
}
