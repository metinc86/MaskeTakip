using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etities.Concrete
{
    public class Citizen
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirth { get; set; }

    }
}
