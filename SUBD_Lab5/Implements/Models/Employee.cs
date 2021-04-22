using System;
using System.ComponentModel.DataAnnotations;

namespace Implements.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
