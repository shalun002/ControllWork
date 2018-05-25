using MedicalOrganization.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalOrganization.Module.Services;

namespace MedicalOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            PacientServise ps = new PacientServise();
            MedOrgService ms = new MedOrgService();

            ServiceZakreplenie sz = new ServiceZakreplenie();
            string message = "";
            sz.Zakreplenie(ref ms, ref ps, out message);
        }
    }
}
