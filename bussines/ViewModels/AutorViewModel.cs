using bussines.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace bussines.ViewModels
{
    public class AutorViewModel : BaseViewModel
    {
        [Column(title: "ФИО", width: 100)]
        public String FIO { get; set; }
        [Column(title: "Почта", width: 100)]
        public String Email { get; set; }
        [Column(title: "Дата рождения", width: 100)]
        public DateTime DateOfBirth { get; set; }
        [Column(title: "Место работы", width: 100)]
        public String PlaceWork { get; set; }
        public int PaperId { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "FIO",
            "Email",
            "DateOfBirth",
            "PlaceWork",
            "PaperId"
        };
    }
}
