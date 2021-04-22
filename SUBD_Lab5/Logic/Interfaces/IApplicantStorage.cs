using Logic.BindingModels;
using Logic.ViewModels;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IApplicantStorage
    {
        List<ApplicantVM> GetFullList();
        List<ApplicantVM> GetFilteredList(ApplicantBM model);
        ApplicantVM GetElement(ApplicantBM model);
        void Insert(ApplicantBM model);
        void Update(ApplicantBM model);
        void Delete(ApplicantBM model);
    }
}
