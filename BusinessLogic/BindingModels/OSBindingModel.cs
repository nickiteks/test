using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BindingModels
{
    public class OSBindingModel
    {
        public int Id { get; set; }
        public string version { get; set; }
        public string name { get; set; }
        public DateTime dateCreate { get; set; }
    }
}
