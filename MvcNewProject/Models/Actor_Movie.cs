using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNewProject.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; } // Create Column MovieId in intermmediate table Actor_Movie
        public Movie Movie { get; set; } // Relationship (Many-to_One): Many Actor_Movie Has one Movie 

        public int ActorId { get; set; } // Create Column ActorId in intermmediate table Actor_Movie
        public Actor Actor { get; set; } // Relationship (Many-to_One): Many Actor_Movie Has one Actor 

        //Note : The Foreign key of Actor and Movie will be declared in DbContext IN Method OnModelCreating(ModelBuilder modelBuilder)
    }
}
