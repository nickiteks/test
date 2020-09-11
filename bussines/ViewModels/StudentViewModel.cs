using bussines.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace bussines.ViewModels
{
    public class StudentViewModel : BaseViewModel
    {
        [Column(visible: false)]
        public int GroupId { get; set; }
        [Column(title: "Зачетная книжка", width: 100)]
        public int RecordBook { get; set; }
        [Column(title: "ФИО", width: 100)]
        public String FIO { get; set; }
        [Column(title: "Дата зачисления", width: 100)]
        public DateTime DateOfCrediting { get; set; }
        [Column(title: "Проходной бал", width: 100)]
        public int PassingScore { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "RecordBook",
            "FIO",
            "DateOfCrediting",
            "PassingScore",
        };
    }
}
