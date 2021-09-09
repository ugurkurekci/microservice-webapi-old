using Category.API.DataAccess.Abstract;
using Category.API.Entities.Concretes;
using Core;
using DataContext.Context;
using System.Collections.Generic;
using System.Linq;

namespace Category.API.DataAccess.Concrete
{
    public class CategoryDal : RepositoryBase<CategoryModel, DatabaseContext>, ICategoryDal
    {
        public CategoryModel GetCategoryModelByID(int categoryId)
        {
            using DatabaseContext context = new DatabaseContext();
            return context.Category.Find(categoryId);
        }

        public CategoryModel GetCategoryModelByName(string categoryName)
        {
            using DatabaseContext context = new DatabaseContext();
            return context.Category.Where(p => p.CategoryName == categoryName).FirstOrDefault();


        }

        public List<CategoryModel> GetCategoryNameSearchList(string categoryName)
        {
            using DatabaseContext context = new DatabaseContext();
            return context.Category.Where(p => p.CategoryName == categoryName).ToList();

        }
    }
}
