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
    
        [Display(Name="Profile Picture URL")]
        public string ProfilePictureURL{ get; set; }
       
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
       
        
        [Display(Name = "Biogrphy")]
        public string Bio { get; set; }

        //Relationship with Actor_Movie
        public List<Actor_Movie> Actors_Movies { get; set; } //Relationship (One-to-Many): One Actor Has Many Movies 

    }
}
