using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using System;
using System.Collections.Generic;

namespace Logic.Logic
{
    public class AppliacntLogic
    {
        private readonly IApplicantStorage _applicantStorage;
        public AppliacntLogic(IApplicantStorage applicantStorage)
        {
            _applicantStorage = applicantStorage;
        }
        public List<ApplicantVM> Read(ApplicantBM model)
        {
            if (model == null)
            {
                return _applicantStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ApplicantVM> { _applicantStorage.GetElement(model) };
            }
            return _applicantStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(ApplicantBM model)
        {
            if (model.Id.HasValue)
            {
                _applicantStorage.Update(model);
            }
            else
            {
                _applicantStorage.Insert(model);
            }
        }
        public void Delete(ApplicantBM model)

        {
            var element = _applicantStorage.GetElement(new ApplicantBM
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Соискатель не найден");
            }
            _applicantStorage.Delete(model);
        }
    }
}
