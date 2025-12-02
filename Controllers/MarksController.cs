using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Data;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MarksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("AddMarks")]
        public async Task<IActionResult> AddMarks([FromBody] Marks marks)
        {
            _context.Marks.Add(marks);
            await _context.SaveChangesAsync();
            return Ok(marks);
        }

        [HttpGet("GetAllMarks")]
        public async Task<IActionResult> GetAllMarks()
        {
            var marks = await _context.Marks.ToListAsync();
            return Ok(marks);
        }

        [HttpPut("CalculateTotalMarks")]
        public async Task<IActionResult> CalculateTotalMarks()
        {
            var allMarks = await _context.Marks.ToListAsync();
            foreach (var mark in allMarks)
            {
                mark.TotalMarks = mark.Tamil + mark.English + mark.Maths + mark.Science + mark.Social;
            }
            await _context.SaveChangesAsync();
            return Ok(allMarks);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMarks(int id)
        {
            var mark = await _context.Marks.FindAsync(id);
            if (mark == null)
                return NotFound();

            _context.Marks.Remove(mark);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }


}

