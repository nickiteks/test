using bussines.Attributes;
using System;
using System.Collections.Generic;

namespace bussines.ViewModels
{
    public class PaperViewModel : BaseViewModel
    {
        [Column(title: "Название", width: 100)]
        public String Name { get; set; }
        [Column(title: "Тема", width: 100)]
        public String Theme { get; set; }
        [Column(title: "Дата создания", width: 100)]
        public DateTime DateCreate { get; set; }

        public override List<string> Properties() => new List<string>
        {
            "Id",
            "Name",
            "Theme",
            "DateCreate",
        };
    }
}
