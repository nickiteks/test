using System;
using System.Collections.Generic;
using System.Text;

namespace bussines.BindingModels
{
    public class StudentBindingModel
    {
        public int? Id { get; set; }
        public int GroupId { get; set; }
        public int RecordBook { get; set; }
        public String FIO { get; set; }
        public DateTime DateOfCrediting { get; set; }
        public int PassingScore { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
