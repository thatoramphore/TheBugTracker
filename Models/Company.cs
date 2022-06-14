using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TheBugTracker.Models
{
    public class Company
    {
        public int Id { get; set; }

        [DisplayName("Company Name")]
        public string Name { get; set; }

        [DisplayName("Company Description")]
        public string Description { get; set; }

        //navigation properties
        public virtual ICollection<BTUser> Members { get; set; } 
        public virtual ICollection<Project> Projects { get; set; }

        //create relationship to Invites
        //public virtual ICollection<Invite> Invites { get; set; } = new HashSet<Invite>();
    }
}
