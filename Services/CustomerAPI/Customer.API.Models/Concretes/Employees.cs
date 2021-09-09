using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Company.API.Models.Concretes
{
    public class Employees : IEntity
    {
        [Key]
        public int EmployeesId { get; set; }



        [RegularExpression("([0-9]+)", ErrorMessage = " Gecerli Bir Format Giriniz ")]
        [Required(ErrorMessage = " Meslek Grubu Bos Birakilamaz ")]
        public int JobId { get; set; }



        [RegularExpression("([0-9]+)", ErrorMessage = " Gecerli Bir Format Giriniz ")]
        [Required(ErrorMessage = " Departman Bos Birakilamaz ")]
        public int DeparmentId { get; set; }


        [RegularExpression("([0-9]+)", ErrorMessage = " Gecerli Bir Format Giriniz ")]
        [Required(ErrorMessage = " Telefon Bos Birakilamaz ")]
        public int PhoneId { get; set; }



        [RegularExpression("([0-9]+)", ErrorMessage = " Gecerli Bir Format Giriniz ")]
        [Required(ErrorMessage = " Email Bos Birakilamaz ")]
        public int EmailId { get; set; }




        [RegularExpression("([0-9]+)", ErrorMessage = " Gecerli Bir Format Giriniz ")]
        [StringLength(11)]
        [Required(ErrorMessage = " Kimlik Numarasi Bos Birakilamaz ")]
        public string IdentityNumberId { get; set; }



        [Required(ErrorMessage = " İsim Bos Birakilamaz ")]
        [StringLength(30)]
        public string EmployeesName { get; set; }



        [Required(ErrorMessage = " Soyisim Bos Birakilamaz ")]
        [StringLength(30)]
        public string EmployeesLastName { get; set; }




        [Required(ErrorMessage = " Dogum Tarihi Bos Birakilamaz ")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? BirthDay { get; set; }


        [DisplayFormat(DataFormatString = "{0:c}")]
        [Required(ErrorMessage = " Maas Bilgisi Bos Birakilamaz ")]
        [RegularExpression("([0-9]+)", ErrorMessage = " Gecerli Bir Format Giriniz ")]
        public double Salary { get; set; }



        public string FullName => $"{EmployeesName} {EmployeesLastName}";



        public DateTime? DateWorkStart => DateTime.Now;
        public DateTime? DateOutWork => DateTime.MaxValue;




        public Deparment Deparment { get; set; }
        public Job Job { get; set; }

        public Email Email { get; set; }
        public Phone Phone { get; set; }
    }
}
