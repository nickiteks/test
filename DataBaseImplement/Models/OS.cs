using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseImplement.Models
{
    [Serializable]
    public class OS
    {
        public int Id { get; set; }
        public string version { get; set; }
        public string name { get; set; }
        public DateTime dateCreate { get; set; }
        public virtual List<PO> POs { get; set; }
    }
}
