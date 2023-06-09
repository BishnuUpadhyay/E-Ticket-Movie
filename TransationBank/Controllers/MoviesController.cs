﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TransationBank.Data;

namespace ETicketApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult>  Index()
        {
            var AllMovies = await _context.Movies.Include(n=>n.Cinema).OrderBy(n=>n.Name).ToListAsync();
            return View("MovieView",AllMovies);
        }
    }
}
