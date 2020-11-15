using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace ClassLibraryControlSelected
{
    public partial class ControlListBox : UserControl
    {
        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        private int _selectedIndex;

        public ObjectCollection Items 
        {
            get
            {
                return listBox.Items;
            } 
        }
        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        private event EventHandler _listBoxSelectedElementChange;

        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        /// 

        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                if (value > -2 && value < listBox.Items.Count)
                {
                    _selectedIndex = value;
                    listBox.SelectedIndex = _selectedIndex;
                }
            }
        }
        /// <summary>
        /// Текст выбранной записи
        /// </summary>
        [Category("Спецификация"), Description("Текст выбранной записи")]
        public string SelectedText
        {
            get { return listBox.Text; }
        }
        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        [Category("Спецификация"), Description("Событие выбора элемента из списка")]
        public event EventHandler ListBoxSelectedElementChange
        {
            add { _listBoxSelectedElementChange += value; }
            remove { _listBoxSelectedElementChange -= value; }
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        public ControlListBox()
        {
            InitializeComponent();
            listBox.SelectedIndexChanged += (sender, e) => {
                _listBoxSelectedElementChange?.Invoke(sender, e);
            };
        }
    }
}
