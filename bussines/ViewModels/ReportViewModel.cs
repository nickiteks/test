using System;

namespace bussines.ViewModels
{
    public class ReportViewModel
    {
        public String NameGroup { get; set; }
        public DateTime DateCreate { get; set; }
        public String FIOStudent { get; set; }
        public DateTime DateOfCrediting { get; set; }
        public int PassingScore { get; set; }
    }
}
