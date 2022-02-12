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

        public IEnumerable<ContractorType> GetContractorTypes()
        {
            return _appDbContext.ContractorTypes.ToArray();
        }

        public bool AddContractor(Contractor contractor)
        {
            _appDbContext.Contractors.Add(contractor);
            _appDbContext.SaveChanges();
            return true;
        }

        public Contractor GetContractorById(int id)
        {
            return _appDbContext.Contractors.FirstOrDefault(c => c.Id == id);
        }

        public bool EditContractor(Contractor contractor)
        {

            var contractorToEdit = _appDbContext.Contractors.FirstOrDefault(c => c.Id == contractor.Id);

            contractorToEdit.Name = contractor.Name;
            contractorToEdit.NipNumber = contractor.NipNumber;
            contractorToEdit.IsActive = contractor.IsActive;
            contractorToEdit.Details = contractor.Details;
            contractorToEdit.ContractorTypeId = contractor.ContractorTypeId;

            _appDbContext.SaveChanges();
            return true;
        }

        public bool DeleteContractorById(int id)
        {
            var contractorToDelete = _appDbContext.Contractors.FirstOrDefault(c => c.Id == id);
            _appDbContext.Contractors.Remove(contractorToDelete);
            _appDbContext.SaveChanges();
            return true;
        }
    }
}
