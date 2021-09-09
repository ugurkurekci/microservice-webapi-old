using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Company.API.Models.Concretes
{
    public class Email : IEntity
    {
        [Key]
        public int EmailId { get; set; }



        [Required(ErrorMessage = " Email Adresi Bos Birakilamaz ")]
        [EmailAddress]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                           ErrorMessage = " Email Adresi Gecersiz ")]
        public string EmailAdress { get; set; }



        public ICollection<Manager> Manager { get; set; }
        public ICollection<Employees> Employees { get; set; }


    }
}
