using System;

namespace Logic.BindingModels
{
    public class ApplicantBM
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public string Education { get; set; }
        public string Specialty { get; set; }
    }
}
