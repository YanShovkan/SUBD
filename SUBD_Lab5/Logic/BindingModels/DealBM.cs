using System;

namespace Logic.BindingModels
{
    public class DealBM
    {
        public int? Id { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeId { get; set; }
        public int ApplicantId { get; set; }
        public int VacancyId { get; set; }
      
    }
}
