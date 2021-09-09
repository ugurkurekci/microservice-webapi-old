using Core;
using Company.API.Models.Concretes;
using System.Collections.Generic;

namespace Company.API.DataAccess.Abstract
{
    public interface ICityDal : IRepository<City>
    {
        City GetCityByID(int categoryId);
        City GetCityByName(string categoryName);
        List<City> GetCityOrCountryId(int countryId);
    }
}
