using ContractorCRUDapp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractorCRUDapp
{
    public class CrudService : ICrudService
    {
        private readonly ApplicationDbContext _appDbContext;
        
        public CrudService(ApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }

        public IEnumerable<Contractor> GetAllContractors()
        {
            return _appDbContext.Contractors.ToArray(); 
        }
    }
}
