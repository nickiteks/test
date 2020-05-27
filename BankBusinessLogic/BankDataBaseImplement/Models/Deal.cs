using BankBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BankDataBaseImplement.Models
{
    public class Deal
    {
        public int Id { get; set; }
        [Required]
        public string DealName { get; set; }
        [Required]
        public DealStatus Status { get; set; }
        public virtual List<DealCredits> DealCredits { get; set; }
    }
}
