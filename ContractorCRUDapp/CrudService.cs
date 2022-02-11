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
        public IEnumerable<Contractor> GetAllContractors()
        {
            IEnumerable <Contractor> list = new List<Contractor> { 
            
                new Contractor{ Name = "TestName" },
                new Contractor{ },
                new Contractor{ },
            };

            return list; 
        }
    }
}
