using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anton.Models
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Supervisor { get; set; }

        //Foreign Key 
        public ICollection<Artist> Artists { get; set; }
    }
}
