using Category.API.Entities.Concretes;
using Core;
using System.Collections.Generic;

namespace Category.API.DataAccess.Abstract
{
    public interface ICategoryDal : IRepository<CategoryModel>
    {
        CategoryModel GetCategoryModelByID(int categoryId);
        CategoryModel GetCategoryModelByName(string categoryName);
        List<CategoryModel> GetCategoryNameSearchList(string categoryName);
    }
}
