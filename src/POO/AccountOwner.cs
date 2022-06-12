using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class AccountOwner
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Identifier { get; set; }
        public AccountOwner(string name, string lastName, string identifier)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Identifier = identifier;
        }
    }
}
