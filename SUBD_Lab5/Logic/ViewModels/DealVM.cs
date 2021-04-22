using System;
using System.ComponentModel;

namespace Logic.ViewModels
{
    public class DealVM
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ApplicantId { get; set; }
        public int VacancyId { get; set; }
        [DisplayName("Фамилия соискателя")]
        public string AppliacntSurname { get; set; }
        [DisplayName("Фамилия сотрудника")]
        public string EmployeeSurname { get; set; }
        [DisplayName("Должность")]
        public string Position { get; set; }
        [DisplayName("Зарплата")]
        public int Salary { get; set; }
        [DisplayName("Дата заключения сделки")]
        public DateTime Date { get; set; }
    }
}
