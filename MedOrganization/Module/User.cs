using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOrganization.Module
{
    public enum AccessRights { User = 1, Admin }
    public class User
    {
        public string Login { get; set; }
        public string Pass { get; set; }
        public AccessRights Access_ { get; set; }
    }
}
