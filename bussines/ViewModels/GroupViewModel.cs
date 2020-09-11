using bussines.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace bussines.ViewModels
{
    public class GroupViewModel : BaseViewModel
    {
        [Column(title: "Название", width: 100)]
        public String Name { get; set; }
        [Column(title: "Направление", width: 100)]
        public String Direct { get; set; }
        [Column(title: "Дата создания", width: 100)]
        public DateTime DateCreate { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "Name",
            "Direct",
            "DateCreate"
        };
    }
}
