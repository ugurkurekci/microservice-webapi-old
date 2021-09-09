using Company.API.Business.Abstract;
using Company.API.DataAccess.Abstract;
using Company.API.Models.Concretes;
using System.Collections.Generic;

namespace Company.API.Business.Concrete
{
    public class CityService : ICityService
    {
        readonly ICityDal _cityDal;

        public CityService(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void Add(City city)
        {
            _cityDal.Add(city);
        }

        public void Delete(City city)
        {
            _cityDal.Delete(city);
        }

        public List<City> GetAll()
        {
            return _cityDal.GetAll();
        }

        public City GetByCityName(string cityName)
        {
            return _cityDal.GetCityByName(cityName);
        }

        public City GetById(int id)
        {
            return _cityDal.GetCityByID(id);
        }

        public List<City> GetCityOrCountryId(int countryId)
        {
            return _cityDal.GetCityOrCountryId(countryId);
        }

        public void Update(City city)
        {
            _cityDal.Update(city);
        }
    }
}
