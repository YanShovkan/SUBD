using System;
using System.ComponentModel.DataAnnotations;

namespace Implements.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        public string Education { get; set; }
        public string Specialty { get; set; }
    }
}
