using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineVotingApp.Data;
using OnlineVotingApp.Model;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace OnlineVotingApp.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class VoterRegistrationsController : ControllerBase
    {

        private readonly OnlineVotingAppContext _context;
       

        public VoterRegistrationsController(OnlineVotingAppContext context)
        {
            _context = context;
        }

        // GET: api/CandidateRegistrations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoterRegistration>>> GetCandidateRegistration()
        {
            return await _context.CandidateRegistration.ToListAsync();
        }


        //POST: api/CandidateRegistrations
        [HttpPost]
        public async Task<ActionResult<VoterRegistration>> PostCandidateRegistration(VoterRegistration candidateRegistration,long aadharnumber, string mobileNumber)
        {
            
            var aadhardata = _context.AadharDB.Find(aadharnumber);

            candidateRegistration.AadharNumber = aadhardata.AadharNumber;
            candidateRegistration.FirstName = aadhardata.FirstName;
            candidateRegistration.LastName = aadhardata.LastName;
            candidateRegistration.Address = aadhardata.Address;
            candidateRegistration.State = aadhardata.State;

            _context.CandidateRegistration.Add(candidateRegistration);
            
            await _context.SaveChangesAsync();

            
            candidateRegistration.VoterId = "VOID" + "" + candidateRegistration.RegistrationID;
            await _context.SaveChangesAsync();

            //----- SMS Gateway ----

            //string accountSid = Environment.GetEnvironmentVariable("AC29d01b73a9ec9ed293796cc07181372c");
            //string authToken = Environment.GetEnvironmentVariable("70e8f98d8902e355a3ee9623285acef7");

            TwilioClient.Init("AC29d01b73a9ec9ed293796cc07181372c", "1f74dc5ea3ad46e3e090e9242cea2ed2");

            var message = MessageResource.Create(
                body: "You have register successfully on the online voting portal.Your voterId is:" + candidateRegistration.VoterId,
                from: new Twilio.Types.PhoneNumber("+12528811717"),
                to: new Twilio.Types.PhoneNumber(mobileNumber)
            );

            Console.WriteLine(message.Sid);

            return CreatedAtAction("GetCandidateRegistration", new { id = candidateRegistration.RegistrationID }, candidateRegistration);
            
           

        }

       
        // DELETE: api/CandidateRegistrations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCandidateRegistration(int id)
        {
            var candidateRegistration = await _context.CandidateRegistration.FindAsync(id);
            if (candidateRegistration == null)
            {
                return NotFound();
            }

            _context.CandidateRegistration.Remove(candidateRegistration);
            await _context.SaveChangesAsync();

            return NoContent();
        }

       
    }
}
