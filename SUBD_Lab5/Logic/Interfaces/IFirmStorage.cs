using Logic.BindingModels;
using Logic.ViewModels;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IFirmStorage
    {
        List<FirmVM> GetFullList();
        List<FirmVM> GetFilteredList(FirmBM model);
        FirmVM GetElement(FirmBM model);
        void Insert(FirmBM model);
        void Update(FirmBM model);
        void Delete(FirmBM model);
    }
}
