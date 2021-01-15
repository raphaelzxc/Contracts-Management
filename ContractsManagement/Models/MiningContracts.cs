using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContractsManagement.Models
{
    public class MiningContracts : Entity
    {
        public string ContractorsName { get; set; }
        public string ReferenceNumber { get; set; }

        public string Amendment_Supplement {get; set;}

        public string TypeofContract { get; set; }

        public string DocumentStatus { get; set; }
   
        public string Name { get; set; }

        public string Addresss { get; set; }

        public string Accreditation { get; set; }

        public string Start { get; set; }

        public string Finish { get; set; }

        public string  PaymentTerms { get; set; }

        public string Scope { get; set; }

        public string Rates { get; set; }

        public string Provisions { get; set; }

        public string WorkProgress { get; set; }

        public string Comments { get; set; }

        public string Recommendation { get; set; }

        public string Owner { get; set; }

    }


}
