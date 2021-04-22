using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using Implements.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Implements.Implements
{
    public class ApplicantStorage : IApplicantStorage
    {
        public List<ApplicantVM> GetFullList()
        {
            using (var context = new DataBaseContext())
            {
                return context.Applicants
                .Select(CreateModel).ToList();
            }
        }

        public List<ApplicantVM> GetFilteredList(ApplicantBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                return context.Applicants
                    .Where(rec => rec.Birthday >= model.Birthday)
                    .Select(CreateModel).ToList();
            }
        }

        public ApplicantVM GetElement(ApplicantBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                var applicant = context.Applicants
                .FirstOrDefault(rec => rec.Id == model.Id);
                return applicant != null ?
                CreateModel(applicant) : null;
            }
        }

        public void Insert(ApplicantBM model)
        {
            using (var context = new DataBaseContext())
            {
                context.Applicants.Add(CreateModel(model, new Applicant()));
                context.SaveChanges();
            }
        }

        public void Update(ApplicantBM model)
        {
            using (var context = new DataBaseContext())
            {
                Applicant element = context.Applicants.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Соискатель не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(ApplicantBM model)
        {
            using (var context = new DataBaseContext())
            {
                Applicant element = context.Applicants.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Applicants.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Соискатель не найден");
                }
            }
        }

        private Applicant CreateModel(ApplicantBM model, Applicant applicant)
        {
            applicant.Name = model.Name;
            applicant.Surname = model.Surname;
            applicant.Patronymic = model.Patronymic;
            applicant.Birthday = model.Birthday;
            applicant.Specialty = model.Specialty;
            applicant.Education = model.Education;
            return applicant;
        }

        private ApplicantVM CreateModel(Applicant applicant)
        {
            return new ApplicantVM
            {
                Id = applicant.Id,
                Name = applicant.Name,
                Surname = applicant.Surname,
                Patronymic = applicant.Patronymic,
                Birthday = applicant.Birthday,
                Specialty = applicant.Specialty,
                Education = applicant.Education
            };
        }
    }
}
