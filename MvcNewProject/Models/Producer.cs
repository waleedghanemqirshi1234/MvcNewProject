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

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        // Relationship with Movie
        public List<Movie> Movies { get; set; } // Relationship (One-to-Many): One Producer Has Many Movies 
    }
}
