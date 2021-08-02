using System.ComponentModel.DataAnnotations;


namespace OnlineVotingApp.Model
{
  
    public class AadharDB
    {
        //[Key]
        //public int ID { get; set; }

        [Required][Key]
        public long AadharNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string State { get; set; }
    
    }
}
