using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Class1
    {
        private int _selectedIndex;

        private int _selectedValue;

        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                _selectedIndex = value;
            }
        }

        public int SelectedValue
        {
            get { return _selectedValue; }
            set
            {
                _selectedValue = value;
            }
        }
    }
}
