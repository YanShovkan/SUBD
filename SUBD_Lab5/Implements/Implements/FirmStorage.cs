using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using Implements.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Implements.Implements
{
    public class FirmStorage : IFirmStorage
    {
        public List<FirmVM> GetFullList()
        {
            using (var context = new DataBaseContext())
            {
                return context.Firms
                .Select(CreateModel).ToList();
            }
        }

        public List<FirmVM> GetFilteredList(FirmBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                return context.Firms
                    .Where(rec => rec.Name == model.Name)
                    .Select(CreateModel).ToList();
            }
        }

        public FirmVM GetElement(FirmBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                var firm = context.Firms
                .FirstOrDefault(rec => rec.Id == model.Id || rec.Name == model.Name);
                return firm != null ?
                CreateModel(firm) : null;
            }
        }

        public void Insert(FirmBM model)
        {
            using (var context = new DataBaseContext())
            {
                context.Firms.Add(CreateModel(model, new Firm()));
                context.SaveChanges();
            }
        }

        public void Update(FirmBM model)
        {
            using (var context = new DataBaseContext())
            {
                var element = context.Firms.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Фирма не найдена");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(FirmBM model)
        {
            using (var context = new DataBaseContext())
            {
                Firm element = context.Firms.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Firms.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Фирма не найдена");
                }
            }
        }

        private Firm CreateModel(FirmBM model, Firm firm)
        {
            firm.Name = model.Name;
            firm.Address = model.Address;
            return firm;
        }

        private FirmVM CreateModel(Firm firm)
        {
            return new FirmVM
            {
                Id = firm.Id,
                Name = firm.Name,
                Address = firm.Address
            };
        }
    }
}
