using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NetExamGuido.Models
{
    public class PetModels
    {
        public int id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Breed { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]
        public State State { get; set; }
        [Required]
        public Animal Animal { get; set; }
        
    }

    public enum State
    {
        Adoption,
        Sale,
    }

    public enum Animal
    {
        Dog,
        Cat,
        Rabbit,
        Hamster,
    }


}