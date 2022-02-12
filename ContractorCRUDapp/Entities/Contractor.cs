using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractorCRUDapp.Entities
{
    public class Contractor
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public string NipNumber { get; set; }
        public int ContractorTypeId { get; set; } = 1; 
        public string Details { get; set; }
        public bool IsActive { get; set; } = true ;
        public virtual ContractorType ContractorType { get; set; }
    }
}
