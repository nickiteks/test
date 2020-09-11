using System;

namespace bussines.BindingModels
{
    public class PaperBindingModel
    {
        public int? Id { get; set; }
        public String Name { get; set; }
        public String Theme { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
