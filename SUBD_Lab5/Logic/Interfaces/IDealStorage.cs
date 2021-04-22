using Logic.BindingModels;
using Logic.ViewModels;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IDealStorage
    {
        List<DealVM> GetFullList();
        List<DealVM> GetFilteredList(DealBM model);
        DealVM GetElement(DealBM model);
        void Insert(DealBM model);
        void Update(DealBM model);
        void Delete(DealBM model);
    }
}
