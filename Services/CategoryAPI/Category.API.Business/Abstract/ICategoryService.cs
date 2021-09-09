using Category.API.Entities.Concretes;
using System.Collections.Generic;

namespace Category.API.Business.Abstract
{
    public interface ICategoryService
    {
        List<CategoryModel> GetAll();
        List<CategoryModel> CategoryListSearch(string category);
        CategoryModel GetById(int Id);
        CategoryModel GetByCategoryName(string categoryName);
        void Add(CategoryModel categoryModel);
        void Delete(CategoryModel categoryModel);
        void Update(CategoryModel categoryModel);
    }
}
