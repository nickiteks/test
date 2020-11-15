using MainLogic.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainLogic.BindingModel
{
    public class OrganizationUnitBindingModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public DateTime? DateReport { get; set; }

        public TypeOrganization typeOrganization { get; set; }
    }
}
