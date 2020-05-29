using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Test_Core_Application.Models
{
    public class Owner
    {
        public int ID { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "First Name must not be 1 to 20 chars")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Last Name must not be 1 to 20 chars")]

        public string LastName { get; set; }
        [NotMapped]
        public string FullName => this.FirstName + " " + this.LastName;

        [Required]
        [StringLength(20, ErrorMessage = "Street must not be 1 to 20 chars")]
        public string Street { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "City must not be 1 to 20 chars")]
        public string City { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Occupation must not be 1 to 20 chars")]
        public string Occupation { get; set; }


        public ICollection<Pet> Pets { get; set; }
    }
}
