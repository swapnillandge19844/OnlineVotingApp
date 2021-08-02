using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingApp.Model
{
    public class PartyCandidateDetails
    {
        [Key]
        public int CandidateId { get; set; }

        public string Party { get; set; }
        public string CandidateName { get; set; }
        
        public string DivisionName { get; set; }

       
    }
}
