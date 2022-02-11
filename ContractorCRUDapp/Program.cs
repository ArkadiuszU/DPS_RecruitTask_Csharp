using ContractorCRUDapp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractorCRUDapp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
       

        private static ApplicationDbContext _appDbContext;
        static void Main()
        {
            var service = new ServiceCollection()
                .AddSingleton<ICrudService, CrudService>()
                .AddDbContext<ApplicationDbContext>();

            
  
            var serviceProvider = service.BuildServiceProvider();

            _appDbContext = serviceProvider.GetService<ApplicationDbContext>();


            if(_appDbContext.Database.CanConnect())
            {

                if (!_appDbContext.ContractorTypes.Any())
                {
                    IEnumerable<ContractorType> list = new List<ContractorType> {

                        new ContractorType { Type = "Klient"}, 
                        new ContractorType { Type = "Potencjalny Klient"}  
            };
                    _appDbContext.ContractorTypes.AddRange(list);
                    _appDbContext.SaveChanges();
                }


                if (!_appDbContext.Contractors.Any())
                {
                    IEnumerable<Contractor> list = new List<Contractor> {

                    new Contractor{ Name = "Test Name 1", NipNumber = "1234567891", ContractorTypeId = 1, Details ="Some Details", IsActive = true },
                    new Contractor{ Name = "Test Name 2", NipNumber = "123456789D", ContractorTypeId = 2, Details ="Some Details", IsActive = false },
                    new Contractor{ Name = "Test Name 3", NipNumber = "123456789A", ContractorTypeId = 1, Details ="Some Details", IsActive = true }
            };
                    _appDbContext.Contractors.AddRange(list);
                    _appDbContext.SaveChanges();
                }

            }


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(serviceProvider.GetService<ICrudService>()));
        }
    }
}
