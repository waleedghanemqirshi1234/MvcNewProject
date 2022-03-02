using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcNewProject.Data;


namespace MvcNewProject.Controllers
{
    public class MoviesController : Controller
    {
        //Dependancy Injection for AppDbContext ==> For DbSet Movies
        private readonly AppDbContext _Context;
        public MoviesController(AppDbContext Context)
        {
            _Context = Context;
        }
       
        public async Task<IActionResult> Index()
        {
            var Data = await _Context.Movies.ToListAsync();
            return View(Data);
        }
    }
}
