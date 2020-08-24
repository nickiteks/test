﻿using BankBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBusinessLogic.HelperModelsClient
{
    public class WordInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportDealViewModel> Deals { get; set; }
    }
}
