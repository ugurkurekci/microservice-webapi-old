using Company.API.Models.Concretes;
using System.Collections.Generic;

namespace Company.API.Business.Abstract
{
    public interface ICityService
    {
        List<City> GetAll();
        List<City> GetCityOrCountryId(int countryId);
        City GetById(int Id);
        City GetByCityName(string cityName);
        void Add(City city);
        void Delete(City city);
        void Update(City city);
    }
}
