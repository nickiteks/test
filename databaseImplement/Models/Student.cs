using System;
using System.Collections.Generic;
using System.Text;

namespace databaseImplement.Models
{
    public class Student
    {
        public int? Id { get; set; }
        public int GroupId { get; set; }
        public int RecordBook { get; set; }
        public String FIO { get; set; }
        public DateTime DateOfCrediting { get; set; }
        public int PassingScore { get; set; }
        public virtual Group Group { get; set; }
    }
}
