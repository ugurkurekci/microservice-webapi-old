using Company.API.Business.Abstract;
using Company.API.DataAccess.Abstract;
using Company.API.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.API.Business.Concrete
{
    public class CountryService : ICountryService
    {
        readonly ICountryDal _countryDal;

        public CountryService(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public void Add(Country country)
        {
            _countryDal.Add(country);
        }

        public void Delete(Country country)
        {
            _countryDal.Delete(country);
        }

        public List<Country> GetAll()
        {
            return _countryDal.GetAll();
        }

        public Country GetById(int Id)
        {
            return _countryDal.GetCountryByID(Id);
        }


        public Country GetCountryByName(string countryByName)
        {
            return _countryDal.GetCountryByName(countryByName);
        }

        public Country GetCountryCodeId(string CountryCodeId)
        {
            return _countryDal.GetCountryCodeId(CountryCodeId);
        }

        public Country GetCountryNumericId(int NumericId)
        {
            return _countryDal.GetCountryNumericId(NumericId);
        }

        public void Update(Country country)
        {
            _countryDal.Update(country);
        }
    }
}
