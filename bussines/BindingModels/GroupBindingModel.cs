using System;
using System.Collections.Generic;
using System.Text;

namespace bussines.BindingModels
{
    public class GroupBindingModel
    {
        public int? Id { get; set; }
        public String Name { get; set; }
        public String Direct { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
