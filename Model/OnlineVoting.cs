using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingApp.Model
{
    public class OnlineVoting
    {
        [Key]
        public int Id { get; set; }
        
        
        public int CandidateId { get; set; }
       
    }
}
