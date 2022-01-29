using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNewProject.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationship : One Cinema Has Many Movies (One-to-Many)
        public List<Movie> Movies { get; set; } //Create foreign key column CinemaId In table Movie

    }
}
