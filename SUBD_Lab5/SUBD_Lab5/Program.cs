using Logic.Logic;
using Logic.Interfaces;
using Implements.Implements;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace SUBD_Lab5
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<MainForm>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IFirmStorage, FirmStorage>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<FirmLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IApplicantStorage, ApplicantStorage>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<AppliacntLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IEmployeeStorage, EmployeeStorage>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<EmployeeLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IVacancyStorage, VacancyStorage>(new
          HierarchicalLifetimeManager());
            currentContainer.RegisterType<VacancyLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IDealStorage, DealStorage>(new
          HierarchicalLifetimeManager());
            currentContainer.RegisterType<DealLogic>(new
           HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
