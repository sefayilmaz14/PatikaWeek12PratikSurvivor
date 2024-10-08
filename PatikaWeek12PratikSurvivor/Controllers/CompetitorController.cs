﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatikaWeek12PratikSurvivor.Context;
using PatikaWeek12PratikSurvivor.Entites;

namespace PatikaWeek12PratikSurvivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly PatikaSurvivorDbContext _context;

        public CompetitorController(PatikaSurvivorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var competitor = await _context.Competitors.ToListAsync();

            return Ok(competitor);
        }
        //Get /api/competitors/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompetitor(int id)
        {
            var competitor = await _context.Competitors.FindAsync(id);
            if (competitor is null) return NotFound();
            return Ok(competitor);
        }

        //Get /api/competitors/categories/{categoryId}
        [HttpGet("categories/{categoryId}")]
        public async Task<IActionResult> GetCompetitorsByCategory(int categoryId)
        {
            var competitors = await _context.Competitors.Where(c => c.CategoryId == categoryId).ToListAsync();
            return Ok(competitors);
        }

        //POST /api/competitors
        [HttpPost]
        public async Task<IActionResult> CreateCompetitor([FromBody] CompetitorEntity competitor)
        {
            _context.Competitors.Add(competitor);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCompetitor), new { id = competitor.Id }, competitor);
        }

        //PUT /api/competitors/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompetitor(int id, [FromBody] CompetitorEntity competitor)
        {
            if (id != competitor.Id) return BadRequest();
            _context.Entry(competitor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        //DELETE /api/competitors/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompetitor(int id)
        {
            var competitor = await _context.Competitors.FindAsync(id);
            if (competitor is null) return NotFound();
            _context.Competitors.Remove(competitor);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
