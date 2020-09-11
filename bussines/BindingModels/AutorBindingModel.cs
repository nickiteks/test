using System;

namespace bussines.BindingModels
{
    public class AutorBindingModel
    {
        public int? Id { get; set; }
        public String FIO { get; set; }
        public String Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String PlaceWork { get; set; }
        public int PaperId { get; set; }
    }
}
