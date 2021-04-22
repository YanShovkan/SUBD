using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using System;
using System.Collections.Generic;

namespace Logic.Logic
{
    public class VacancyLogic
    {
        private readonly IVacancyStorage _vacancyStorage;
        public VacancyLogic(IVacancyStorage vacancyStorage)
        {
            _vacancyStorage = vacancyStorage;
        }
        public List<VacancyVM> Read(VacancyBM model)
        {
            if (model == null)
            {
                return _vacancyStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<VacancyVM> { _vacancyStorage.GetElement(model) };
            }
            return _vacancyStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(VacancyBM model)
        {
            if (model.Id.HasValue)
            {
                _vacancyStorage.Update(model);
            }
            else
            {
                _vacancyStorage.Insert(model);
            }
        }
        public void Delete(VacancyBM model)

        {
            var element = _vacancyStorage.GetElement(new VacancyBM
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Вакансия не найдена");
            }
            _vacancyStorage.Delete(model);
        }

        public void UpdateEmployment(VacancyBM model)
        {
            var element = _vacancyStorage.GetElement(new VacancyBM
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Вакансия не найдена");
            }
            _vacancyStorage.UpdateEmployment(model);
        }
    }
}
