using System;
using System.ComponentModel.DataAnnotations;

namespace databaseImplement.Models
{
    [Serializable]
    public class Paper
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Theme { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
    }
}
