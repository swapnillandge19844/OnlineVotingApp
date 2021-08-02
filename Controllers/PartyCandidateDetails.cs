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
    public class PartyCandidateDetails : ControllerBase
    {
        private readonly OnlineVotingAppContext _context;

        public PartyCandidateDetails(OnlineVotingAppContext context)
        {
            _context = context;
        }

        // GET: api/VotingModules
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Model.PartyCandidateDetails>>> GetVotingModule()
        {
            return await _context.VotingModule.ToListAsync();
        }

        
    }
}
