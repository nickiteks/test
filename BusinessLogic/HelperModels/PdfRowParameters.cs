﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.HelperModels
{
    public class PdfRowParameters
    {
        public Table Table { get; set; }
        public List<string> Texts { get; set; }
        public string Style { get; set; }
        public ParagraphAlignment ParagraphAlignment { get; set; }
    }
}
