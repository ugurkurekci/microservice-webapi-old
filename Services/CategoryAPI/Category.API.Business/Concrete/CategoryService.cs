using Category.API.Business.Abstract;
using Category.API.DataAccess.Abstract;
using Category.API.Entities.Concretes;
using System.Collections.Generic;

namespace Category.API.Business
{
    public class CategoryService : ICategoryService
    {
        readonly ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            this._categoryDal = categoryDal;
        }

        public void Add(CategoryModel categoryModel)
        {
            _categoryDal.Add(categoryModel);
        }

        public void Delete(CategoryModel categoryModel)
        {
            _categoryDal.Delete(categoryModel);
        }

        public List<CategoryModel> GetAll()
        {
            return _categoryDal.GetAll();
        }


        public CategoryModel GetByCategoryName(string categoryName)
        {
            return _categoryDal.GetCategoryModelByName(categoryName);
        }

        public List<CategoryModel> CategoryListSearch(string category)
        {

            return _categoryDal.GetCategoryNameSearchList(category);

        }

        public CategoryModel GetById(int Id)
        {
            return _categoryDal.GetCategoryModelByID(Id);
        }

        public void Update(CategoryModel categoryModel)
        {
            _categoryDal.Update(categoryModel);
        }
    }
}
