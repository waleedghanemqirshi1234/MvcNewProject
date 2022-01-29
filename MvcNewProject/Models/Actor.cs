using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNewProject.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
    
        public string ProfilePictureURL{ get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationship : One Actor Has Many Movies (One-to-Many) 
        public List<Actor_Movie> Actors_Movies { get; set; } //Create foreign key column ActorId In table Actor_Movie

    }
}
