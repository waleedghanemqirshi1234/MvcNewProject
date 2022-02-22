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
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }


        //Relationship With Actor_Movies
        public List<Actor_Movie> Actors_Movies { get; set; }  //Relationship (One-to-Many): One Movie Has Many Actor_Movies 

        //Relationship With Cinema
        public int CinemaId { get; set; }  // Create Column CinemaId in table Movies as foreign key
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; } //Relationship (Money-to-one): Many Movies Has one Cinema 

        //Relationship With Producer
        public int ProducerId { get; set; }    // Create Column ProducerId in table Movies as foreign key 
        [ForeignKey("ProducerId")]
        public Producer Prodeucer { get; set; } //Relationship (Money-to-one): Many Movies Has one Producer 
    }
}
