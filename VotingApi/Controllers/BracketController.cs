using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VotingApi.Data;
using VotingApi.Entities;

namespace VotingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BracketController : ControllerBase
    {

        private readonly BracketDbContext _context;

        public BracketController(BracketDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Bracket>>> GetAllBrackets()
        {
            var brackets = await _context.Brackets.ToListAsync();

            return Ok(brackets);
        }

        [HttpPost]
        public async Task<ActionResult<Bracket>> AddBracket(Bracket newBracket)
        {

            _context.Brackets.Add(newBracket);
            await _context.SaveChangesAsync();

            return Ok(newBracket);
        }
    }
}
