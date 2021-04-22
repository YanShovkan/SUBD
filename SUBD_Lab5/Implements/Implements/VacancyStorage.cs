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
    public class VacancyStorage : IVacancyStorage
    {
        public List<VacancyVM> GetFullList()
        {
            using (var context = new DataBaseContext())
            {
                return context.Vacancyes
                    .Include(rec => rec.Firm)
                .Select(CreateModel).ToList();
            }
        }

        public List<VacancyVM> GetFilteredList(VacancyBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                return context.Vacancyes
                    .Include(rec => rec.Firm)
                    .Where(rec => rec.Employment == model.Employment)
                    .Select(CreateModel).ToList();
            }
        }

        public VacancyVM GetElement(VacancyBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                var vacancy = context.Vacancyes
                    .Include(rec => rec.Firm)
                .FirstOrDefault(rec => rec.Id == model.Id);
                return vacancy != null ?
                CreateModel(vacancy) : null;
            }
        }

        public void Insert(VacancyBM model)
        {
            using (var context = new DataBaseContext())
            {
                context.Vacancyes.Add(CreateModel(model, new Vacancy()));
                context.SaveChanges();
            }
        }

        public void Update(VacancyBM model)
        {
            using (var context = new DataBaseContext())
            {
                Vacancy element = context.Vacancyes.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Вакансия не найдена");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(VacancyBM model)
        {
            using (var context = new DataBaseContext())
            {
                Vacancy element = context.Vacancyes.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Vacancyes.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Вакансия не найдена");
                }
            }
        }

        private Vacancy CreateModel(VacancyBM model, Vacancy vacancy)
        {
            vacancy.Schedule = model.Schedule;
            vacancy.Position = model.Position;
            vacancy.Salary = model.Salary;
            vacancy.FirmId = model.FirmId;
            vacancy.Employment = model.Employment;
            return vacancy;
        }

        private VacancyVM CreateModel(Vacancy vacancy)
        {
            return new VacancyVM
            {
                Id = vacancy.Id,
                Schedule = vacancy.Schedule,
                Position = vacancy.Position,
                Salary = vacancy.Salary,
                FirmName = vacancy.Firm.Name,
                Employment = vacancy.Employment
            };
        }

        public void UpdateEmployment(VacancyBM model)
        {
            using (var context = new DataBaseContext())
            {
                Vacancy element = context.Vacancyes.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    element.Employment = true;
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Вакансия не найдена");
                }
            }
        }
    }
}
