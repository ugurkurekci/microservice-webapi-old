using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Company.API.Models.Concretes
{
    public class Country : IEntity
    {

        [Key]
        public int CountryId { get; set; }



        [RegularExpression("([0-9]+)", ErrorMessage = " Gecerli Bir Format Giriniz ")]
        [Required(ErrorMessage = " Ülke Numarasi Bos Birakilamaz ")]
        
        public short CountryNumeric { get; set; }



        
        [Required(ErrorMessage = " Ülke Kodu Bos Birakilamaz ")]
        public string CountryCode { get; set; }




        [Required(ErrorMessage = " Ülke İsmi Bos Birakilamaz ")]
        
        public string CountryName { get; set; }



        public ICollection<City> City { get; set; }

    }
}
