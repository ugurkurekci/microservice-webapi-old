using Company.API.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.API.Business.Abstract
{
    public interface ICountryService
    {
        List<Country> GetAll();
        Country GetById(int Id);
        Country GetCountryByName(string countryByName);
        Country GetCountryNumericId(int NumericId);
        Country GetCountryCodeId(string CountryCodeId);
        void Add(Country country);
        void Delete(Country country);
        void Update(Country country);
    }
}
