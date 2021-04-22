using System;
using System.ComponentModel;

namespace Logic.ViewModels
{
    public class ApplicantVM
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
        [DisplayName("Образование")]
        public string Education { get; set; }
        [DisplayName("Специальность")]
        public string Specialty { get; set; }
    }
}
