﻿using System.ComponentModel.DataAnnotations;

namespace Graph_qL.Models
{
    public class Superhero
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please specify a name for the superhero")]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Height { get; set; }

        public ICollection<Superpower> Superpowers { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
