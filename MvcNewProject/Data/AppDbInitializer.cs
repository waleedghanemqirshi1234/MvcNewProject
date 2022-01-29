using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNewProject.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var ServiesScope =applicationBuilder.ApplicationServices.CreateScope())
            {
                var Context = ServiesScope.ServiceProvider.GetService<AppDbContext>();
                Context.Database.EnsureCreated();


                //Cinemas
                if(!Context.Cinemas.Any())
                {

                }
                //Actors
                if (!Context.Actors.Any())
                {

                }
                //Movies
                if (!Context.Movies.Any())
                {

                }
                //producers
                if (!Context.Producers.Any())
                {

                }
                //Actors & Movies
                if (!Context.Actors_Movies.Any())
                {

                }
            }
        }
    }
}
