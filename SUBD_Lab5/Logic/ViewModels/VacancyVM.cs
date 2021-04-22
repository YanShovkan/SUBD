using System.ComponentModel;

namespace Logic.ViewModels
{
    public class VacancyVM
    {
        public int Id { get; set; }
        public bool Employment { get; set; }
        [DisplayName("График работы")]
        public string Schedule { get; set; }
        [DisplayName("Должность")]
        public string Position { get; set; }
        [DisplayName("Зарплата")]
        public int Salary { get; set; }
        [DisplayName("Название фирмы")]
        public string FirmName { get; set; }
    }
}
