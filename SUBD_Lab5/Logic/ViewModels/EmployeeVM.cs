using System;
using System.ComponentModel;

namespace Logic.ViewModels
{
    public  class EmployeeVM
    {
        public int Id { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Отчество")]
        public string Patronymic { get; set; }
        [DisplayName("Дата рождения")]
        public DateTime Birthday { get; set; }
        [DisplayName("Должность")]
        public string Position { get; set; }
        [DisplayName("Зарплата")]
        public int Salary { get; set; }
    }
}
