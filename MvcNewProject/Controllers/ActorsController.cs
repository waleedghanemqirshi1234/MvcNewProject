using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcNewProject.Data;


namespace MvcNewProject.Controllers
{
    public class ActorsController : Controller
    {
        //Dependancy Injection for AppDbContext ==> For DbSet Actors
        private readonly AppDbContext _Context;
        public ActorsController(AppDbContext Context)
        {
            _Context = Context;
        }
        public IActionResult Index()
        {
            var Data = _Context.Actors.ToList();
            return View(Data);
        }
    }
}
