using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNewProject.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        // Relationship with Movie
        public List<Movie> Movies { get; set; } // Relationship (One-to-Many): One Producer Has Many Movies 
    }
}
