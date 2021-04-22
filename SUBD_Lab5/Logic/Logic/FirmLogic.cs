using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using System;
using System.Collections.Generic;

namespace Logic.Logic
{
    public class FirmLogic
    {
        private readonly IFirmStorage _firmStorage;
        public FirmLogic(IFirmStorage firmStorage)
        {
            _firmStorage = firmStorage;
        }
        public List<FirmVM> Read(FirmBM model)
        {
            if (model == null)
            {
                return _firmStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<FirmVM> { _firmStorage.GetElement(model) };
            }
            return _firmStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(FirmBM model)
        {
            var element = _firmStorage.GetElement(new FirmBM
            {
                Name = model.Name
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Фирма с таким названием уже существует");
            }
            if (model.Id.HasValue)
            {
                _firmStorage.Update(model);
            }
            else
            {
                _firmStorage.Insert(model);
            }
        }
        public void Delete(FirmBM model)

        {
            var element = _firmStorage.GetElement(new FirmBM
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Фирма не найдена");
            }
            _firmStorage.Delete(model);
        }
    }
}
