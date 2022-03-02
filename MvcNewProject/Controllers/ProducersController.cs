using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcNewProject.Data;

namespace MvcNewProject.Controllers
{
    public class ProducersController : Controller
    {
        //Dependancy Injection for AppDbContext ==> For DbSet Producer
        private readonly AppDbContext _Context;
        public ProducersController(AppDbContext Context)
        {
            _Context = Context;
        }
        public async Task<IActionResult> Index()
        {
            var Data = await _Context.Producers.ToListAsync();
            return View(Data);
        }
    }
}
