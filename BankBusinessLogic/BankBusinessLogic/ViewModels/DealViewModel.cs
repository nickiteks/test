using BankBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BankBusinessLogic.ViewModels
{
    public class DealViewModel
    {
        public int Id { get; set; }
        [DisplayName("Сделка")]
        public string DealName { get; set; }
        [DisplayName("Статус")]
        public DealStatus Status { get; set; }
        public Dictionary<int, (string, DateTime?)> DealCredits { get; set; }
    }
}
