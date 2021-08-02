using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineVotingApp.Data;
using OnlineVotingApp.Model;

namespace OnlineVotingApp.Controllers
{
   [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
   [Route("api/[controller]")]
    [ApiController]
    public class OnlineVotingsController : ControllerBase
    {
        private readonly OnlineVotingAppContext _context;

        public OnlineVotingsController(OnlineVotingAppContext context)
        {
            _context = context;
        }

        // GET: api/OnlineVotings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OnlineVoting>>> GetOnlineVoting()
        {
            return await _context.OnlineVoting.ToListAsync();
        }

        
         // POST: api/OnlineVotings
        [HttpPost]
        public async Task<ActionResult<OnlineVoting>> PostOnlineVoting(OnlineVoting onlineVoting)
        {
            _context.OnlineVoting.Add(onlineVoting);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOnlineVoting", new { id = onlineVoting.Id }, onlineVoting);
        }

        

        
    }
}
