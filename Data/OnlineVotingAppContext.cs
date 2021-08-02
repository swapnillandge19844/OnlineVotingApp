using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineVotingApp.Model;

namespace OnlineVotingApp.Data
{
    public class OnlineVotingAppContext : DbContext
    {
        
        public OnlineVotingAppContext (DbContextOptions<OnlineVotingAppContext> options)
            : base(options)
        {
        }

        public DbSet<AadharDB> AadharDB { get; set; }

        public DbSet<VoterRegistration> CandidateRegistration { get; set; }

        public DbSet<PartyCandidateDetails> VotingModule { get; set; }

        
        public DbSet<OnlineVoting> OnlineVoting { get; set; }

       


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<VotingCount>().HasNoKey();
        //}
    }
}
