using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using System;
using System.Collections.Generic;

namespace Logic.Logic
{
    public class DealLogic
    {
        private readonly IDealStorage _dealStorage;
        public DealLogic(IDealStorage dealStorage)
        {
            _dealStorage = dealStorage;
        }
        public List<DealVM> Read(DealBM model)
        {
            if (model == null)
            {
                return _dealStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<DealVM> { _dealStorage.GetElement(model) };
            }
            return _dealStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(DealBM model)
        {
            if (model.Id.HasValue)
            {
                _dealStorage.Update(model);
            }
            else
            {
                _dealStorage.Insert(model);
            }
        }
        public void Delete(DealBM model)

        {
            var element = _dealStorage.GetElement(new DealBM
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Сделка не найдена");
            }
            _dealStorage.Delete(model);
        }
    }
}
