using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineVotingApp.Data;
using OnlineVotingApp.Model;

namespace OnlineVotingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetVoterDetailsFromAadharDBController : ControllerBase
    {
        private readonly OnlineVotingAppContext _context;

        public GetVoterDetailsFromAadharDBController(OnlineVotingAppContext context)
        {
            _context = context;
        }

       
        [HttpGet("{AadharNumber}")]
        public async Task<ActionResult<AadharDB>> GetAadharDB(long AadharNumber)
        {
            var aadharDB = await _context.AadharDB.FindAsync(AadharNumber);

            if (aadharDB == null)
            {
                return NotFound();
            }

            return aadharDB;
        }

    }
}
