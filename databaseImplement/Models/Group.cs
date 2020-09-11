using System;
using System.Collections.Generic;
using System.Text;

namespace databaseImplement.Models
{
    public class Group
    {
        public int? Id { get; set; }
        public String Name { get; set; }
        public String Direct { get; set; }
        public DateTime DateCreate { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
