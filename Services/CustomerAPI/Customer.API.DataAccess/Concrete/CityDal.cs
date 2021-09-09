using Core;
using Company.API.DataAccess.Abstract;
using Company.API.Models.Concretes;
using DataContext.Context;
using System.Linq;
using System.Collections.Generic;

namespace Company.API.DataAccess.Concrete
{
    public class CityDal : RepositoryBase<City, DatabaseContext>, ICityDal
    {

        public City GetCityByID(int city)
        {
            using DatabaseContext context = new DatabaseContext();
            return context.City.Find(city);
        }

        public City GetCityByName(string cityName)
        {
            using DatabaseContext context = new DatabaseContext();
            return context.City.Where(p => p.CityName == cityName).FirstOrDefault();

        }

        public List<City> GetCityOrCountryId(int countryId)
        {
            using DatabaseContext context = new DatabaseContext();
            return context.City.Where(p => p.CountryId == countryId).ToList();
        }
    }
}
