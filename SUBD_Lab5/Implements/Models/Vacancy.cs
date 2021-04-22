using System.ComponentModel.DataAnnotations;

namespace Implements.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        [Required]
        public string Schedule { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public int FirmId { get; set; }
        public  bool Employment { get; set; }
        public virtual Firm Firm { get; set; }
    }
}
