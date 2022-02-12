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
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(serviceProvider.GetService<ICrudService>()));

        }
    }
}
