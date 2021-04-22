namespace Logic.BindingModels
{
    public class VacancyBM
    {
        public int? Id { get; set; }
        public string Schedule { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public int FirmId { get; set; }
        public bool Employment { get; set; }
    }
}
