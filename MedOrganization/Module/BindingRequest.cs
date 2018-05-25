using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOrganization.Module
{
    public class BindingRequest
    {
        public DateTime DateCreateQuery { get; set; }
        public DateTime DateOfProcessingQuery{ get; set; }
        public string Status { get; set; }
        public Pacient Pacien { get; set; }
        public MedOrganization MedOrg { get; set; }
    }
}