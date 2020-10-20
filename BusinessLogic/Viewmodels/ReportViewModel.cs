using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Viewmodels
{
    public class ReportViewModel
    {
        public string version { get; set; }
        public DateTime dataCreateOS { get; set; }
        public string POName { get; set; }
        public string company { get; set; }
        public DateTime dateCreatePO { get; set; }
    }
}
