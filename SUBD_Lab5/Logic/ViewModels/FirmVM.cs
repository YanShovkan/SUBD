using System.Collections.Generic;
using System.ComponentModel;

namespace Logic.ViewModels
{
    public class FirmVM
    {
        public int Id { get; set; }
        [DisplayName("Название фирмы")]
        public string Name { get; set; }
        [DisplayName("Адрес")]
        public string Address { get; set; }
    }
}
