using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Category.API.Entities.Concretes
{
    public class CategoryModel : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Hata")]
        [MinLength(2)]
        public string CategoryName { get; set; }
    }
}
