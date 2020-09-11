using System;
using System.ComponentModel.DataAnnotations;

namespace databaseImplement.Models
{
    [Serializable]
    public class Autor
    {
        public int Id { get; set; }
        [Required]
        public String FIO { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public String PlaceWork { get; set; }
        [Required]
        public int PaperId { get; set; }
        public virtual Paper Paper { get; set; }
    }
}
