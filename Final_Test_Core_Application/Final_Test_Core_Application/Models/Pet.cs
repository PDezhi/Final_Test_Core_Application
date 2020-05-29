using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Test_Core_Application.Models
{

    public enum Breed
    {
        Dog, Cat, Fish, Hamster, GuineaPig
    }

    public class Pet
    {
        public int ID { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Name must not be 1 to 10 chars")]
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        public Breed Breed { get; set; }

        [Required]
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }

}
