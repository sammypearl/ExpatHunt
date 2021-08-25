using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CompanyDetail { get; set; }

    }
}
