using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VotingApi.Data;
using VotingApi.Entities;

namespace VotingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {

        private readonly ImageDbContext _context;

        public ImageController(ImageDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Image>>> GetAllImages()
        {
            var images = await _context.Images.ToListAsync();

            return Ok(images);
        }

        [HttpPost]
        public async Task<ActionResult<Image>> AddImage(Image image)
        {

            _context.Images.Add(image);
            await _context.SaveChangesAsync();

            return Ok(image);
        }
    }
}
