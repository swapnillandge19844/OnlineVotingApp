using OnlineVotingApp.Controllers;
using OnlineVotingApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingApp.Model
{
    
    public class VoterRegistration
    {
        [Key]
       public int RegistrationID { get; set; }

        public double AadharNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string State { get; set; }
        
        
        public string VoterId { get; set; }

    }
}
