using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using Implements.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Implements.Implements
{
    public class DealStorage : IDealStorage
    {
        public List<DealVM> GetFullList()
        {
            using (var context = new DataBaseContext())
            {
                return context.Deals
                    .Include(rec => rec.Vacancy)
                     .Include(rec => rec.Applicant)
                      .Include(rec => rec.Employee)
                .Select(CreateModel).ToList();
            }
        }

        public List<DealVM> GetFilteredList(DealBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                return context.Deals
                     .Include(rec => rec.Vacancy)
                     .Include(rec => rec.Applicant)
                      .Include(rec => rec.Employee)
                    .Where(rec => rec.Date >= model.Date)
                    .Select(CreateModel).ToList();
            }
        }

        public DealVM GetElement(DealBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                var deal = context.Deals
                     .Include(rec => rec.Vacancy)
                     .Include(rec => rec.Applicant)
                      .Include(rec => rec.Employee)
                .FirstOrDefault(rec => rec.Id == model.Id);
                return deal != null ?
                CreateModel(deal) : null;
            }
        }

        public void Insert(DealBM model)
        {
            using (var context = new DataBaseContext())
            {
                context.Deals.Add(CreateModel(model, new Deal()));
                context.SaveChanges();
            }
        }

        public void Update(DealBM model)
        {
            using (var context = new DataBaseContext())
            {
                Deal element = context.Deals.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Сделка не найдена");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(DealBM model)
        {
            using (var context = new DataBaseContext())
            {
                Deal element = context.Deals.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Deals.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Сделка не найдена");
                }
            }
        }

        private Deal CreateModel(DealBM model, Deal deal)
        {
            deal.Date = model.Date;
            deal.EmployeeId = model.EmployeeId;
            deal.ApplicantId = model.ApplicantId;
            deal.VacancyId = model.VacancyId;

            return deal;
        }

        private DealVM CreateModel(Deal deal)
        {
            return new DealVM
            {
                Id = deal.Id,
                EmployeeId = deal.EmployeeId,
                ApplicantId = deal.ApplicantId,
                VacancyId = deal.VacancyId,
                Date = deal.Date,
                AppliacntSurname = deal.Applicant.Surname,
                EmployeeSurname = deal.Employee.Surname,
                Position = deal.Vacancy.Position,
                Salary = deal.Vacancy.Salary
            };
        }
    }
}
