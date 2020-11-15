using MainLogic.DataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.ViewModel
{
    public class OrganizanionUnitViewModel
    {
        public int Id { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Отчество")]
        public string Patronymic { get; set; }
        [DisplayName("Дата отчета")]
        public DateTime? DateReport { get; set; }
        [DisplayName("Тип организации")]
        public TypeOrganization typeOrganization { get; set; }
    }
}
