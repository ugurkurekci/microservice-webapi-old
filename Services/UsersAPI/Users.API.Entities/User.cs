using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Users.API.Entities
{
    public class User : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim Zorunludur")]
        [MinLength(2)]
        public string FirstName { get; set; }
        [MinLength(2)]
        public string LastName { get; set; }
        [MinLength(5)]
        public string Username { get; set; }
        [MinLength(8)]
        public string Password { get; set; }
        [MinLength(7)]
        [EmailAddress]
        [Required]
        public string Email { get; set; }


        public string FullName { get; set; }


        public DateTime? RegisterDate { get; set; }


    }
}
