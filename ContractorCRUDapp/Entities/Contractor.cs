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
        public int NipNimber { get; set; }
        public int ContractorTypeID { get; set; }
        public string Details { get; set; }
        public bool Active { get; set; }
    }
}
