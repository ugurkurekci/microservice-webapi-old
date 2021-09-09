using Category.API.Business.Abstract;
using Category.API.Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace Category.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }


        [HttpGet("Getall")]
        public IActionResult GetAll()
        {

            var result = _categoryService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("{Id}")]
        public CategoryModel GetById(int Id)
        {
            return _categoryService.GetById(Id);
        }


        [HttpGet("GetByCategoryName")]
        public CategoryModel GetByCategoryName(string cName)
        {
            return _categoryService.GetByCategoryName(cName);
        }
        [HttpPost("CategoryPost")]
        public void CategoryPost(CategoryModel cName)
        {
            _categoryService.Add(cName);
            
        }
        [HttpDelete("CategoryDelete")]
        public void CategoryDelete(CategoryModel cName)
        {
            _categoryService.Delete(cName);

        }

        [HttpPut("CategoryPut")]
        public void CategoryPut(CategoryModel cName)
        {
            _categoryService.Update(cName);

        }
    }
}
