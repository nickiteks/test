using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseImplement.Models
{
    [Serializable]
    public class PO
    {
        public int Id { get; set; }
        public int OSId { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public DateTime dateCreate { get; set; }
        public string company { get; set; }
        public virtual OS OS { get; set; }
    }
}
