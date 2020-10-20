using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Viewmodels
{
    public class OSViewModel
    {
        public int Id { get; set; }
        [DisplayName("Версия")]
        public string version { get; set; }
        [DisplayName("Название ОС")]
        public string name { get; set; }
        [DisplayName("Дата создания")]
        public DateTime dateCreate { get; set; }
    }
}
