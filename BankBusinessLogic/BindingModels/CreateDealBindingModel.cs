﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankBusinessLogic.BindingModels
{
    public class CreateDealBindingModel
    {
        public int CreditId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
    }
}
