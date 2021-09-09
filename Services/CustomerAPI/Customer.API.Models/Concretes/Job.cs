using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Company.API.Models.Concretes
{
    public class Job:IEntity
    {

        [Key]
        public int JobId { get; set; }



        [StringLength(40)]
        [Required(ErrorMessage = " Meslek Basligi Bos Birakilamaz ")]
        public string JobTitle { get; set; }
        


        public ICollection<Employees> Employees { get; set; }
        public ICollection<Manager> Manager { get; set; }

    }
}
