using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Company.API.Models.Concretes
{
    public class Deparment : IEntity
    {

        [Key]
        public int DeparmentId { get; set; }



        [Required(ErrorMessage = " Departman Adi Bos Birakilamaz ")]
        public string DeparmentName { get; set; }



        public DateTime? DepartmentSince => DateTime.Now;


        public ICollection<Employees> Employees { get; set; }
        public ICollection<Manager> Manager { get; set; }


    }
}
