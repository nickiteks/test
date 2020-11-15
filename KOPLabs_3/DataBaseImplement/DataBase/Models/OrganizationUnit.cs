using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MainLogic.DataBase.Models
{
    public class OrganizationUnit
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Patronymic { get; set; }

        public DateTime? DateReport { get; set; }
        [Required]
        public TypeOrganization typeOrganization { get; set; }
    }
}
