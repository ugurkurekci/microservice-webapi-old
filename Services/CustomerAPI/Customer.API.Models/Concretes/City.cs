using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Company.API.Models.Concretes
{
    public class City:IEntity
    {

        [Key]
        public int CityId { get; set; }



        [RegularExpression("([0-9]+)", ErrorMessage = " Gecerli Bir Format Giriniz ")]
        [Required(ErrorMessage = " Ülke Bos Birakilamaz ")]
        public int CountryId { get; set; }



        [StringLength(25)]
        [Required(ErrorMessage = " Ülke Adi Birakilamaz ")]
        public string CityName { get; set; }



        public Country Country { get; set; }
    }
}
