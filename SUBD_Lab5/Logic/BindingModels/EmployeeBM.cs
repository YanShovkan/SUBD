using System;

namespace Logic.BindingModels
{
    public class EmployeeBM
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
    }
}
