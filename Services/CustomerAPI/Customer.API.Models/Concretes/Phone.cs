using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Company.API.Models.Concretes
{
    public class Phone : IEntity
    {

        [Key]
        public int PhoneId { get; set; }



        [Phone]
        [StringLength(15)]
        [RegularExpression("([0-9]+)", ErrorMessage = " Gecerli Bir Format Girin ")]
        [Required(ErrorMessage = " Telefon Numarasi Bos Birakilamaz ")]
        public string PhoneNumber { get; set; }




    }
}
