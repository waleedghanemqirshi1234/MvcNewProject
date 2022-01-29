using MvcNewProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNewProject.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
       
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }


        //Relationship : One Movie Has Many Actor_Movies (One-to-Many)
        public List<Actor_Movie> Actors_Movies { get; set; } //Create foreign key column MovieId In table Actor_Movie

        //Relationship : Many Movies Has one Cinema (Money-to-one)
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Relationship : Many Movies Has one Producer (Money-to-one) 
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Prodeucer { get; set; }
    }
}
