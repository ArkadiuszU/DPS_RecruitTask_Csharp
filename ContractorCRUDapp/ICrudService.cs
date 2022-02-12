using ContractorCRUDapp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractorCRUDapp
{
    public interface ICrudService
    {
        public IEnumerable<Contractor> GetAllContractors();

        public Contractor GetContractorById(int id);
        public bool DeleteContractorById(int id);
        public IEnumerable<ContractorType> GetContractorTypes();

        public bool AddContractor(Contractor contractor);
        public bool EditContractor(Contractor contractor);
    }
}
