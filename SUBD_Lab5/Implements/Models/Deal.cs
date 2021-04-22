using System;
using System.ComponentModel.DataAnnotations;

namespace Implements.Models
{
    public class Deal
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public int ApplicantId { get; set; }
        [Required]
        public int VacancyId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Applicant Applicant { get; set; }
        public virtual Vacancy Vacancy { get; set; }
    }
}
