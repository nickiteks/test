using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Viewmodels
{
    public class POViewModel
    {
        public int Id { get; set; }
        [DisplayName("Относиться к ОС")]
        public int OSId { get; set; }
        [DisplayName("Название ПО")]
        public string name { get; set; }
        [DisplayName("Цена")]
        public decimal price { get; set; }
        [DisplayName("Дата созания")]
        public DateTime dateCreate { get; set; }
        [DisplayName("Фирма")]
        public string company { get; set; }
    }
}
