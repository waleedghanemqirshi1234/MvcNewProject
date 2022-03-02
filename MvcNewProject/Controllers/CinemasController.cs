using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcNewProject.Data;

namespace MvcNewProject.Controllers
{
    public class CinemasController : Controller
    {
        //Dependancy Injection for AppDbContext ==> For DbSet Cinemas
        private readonly AppDbContext _Context;
        public CinemasController(AppDbContext Context)
        {
            _Context = Context;
        }
  
        public async Task<IActionResult> Index()
        {
            var Data = await _Context.Cinemas.ToListAsync();
            return View(Data);
        }
    }
}
