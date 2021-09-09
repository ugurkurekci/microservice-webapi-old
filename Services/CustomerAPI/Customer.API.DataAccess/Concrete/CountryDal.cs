using Core;
using Company.API.DataAccess.Abstract;
using Company.API.Models.Concretes;
using DataContext.Context;
using System.Linq;

namespace Company.API.DataAccess.Concrete
{
    public class CountryDal : RepositoryBase<Country, DatabaseContext>, ICountryDal
    {
        

        public Country GetCountryByID(int countryId)
        {
            using DatabaseContext context = new DatabaseContext();
            return context.Country.Where(p => p.CountryId == countryId).FirstOrDefault();
        }

        public Country GetCountryByName(string countryByName)
        {
            using DatabaseContext context = new DatabaseContext();
            return context.Country.Where(p => p.CountryName == countryByName).FirstOrDefault();
        }

        public Country GetCountryCodeId(string CountryCodeId)
        {
            using DatabaseContext context = new DatabaseContext();
            return context.Country.Where(p => p.CountryCode == CountryCodeId).FirstOrDefault();
        }

        public Country GetCountryNumericId(int NumericId)
        {
            using DatabaseContext context = new DatabaseContext();
            return context.Country.Where(p => p.CountryNumeric == NumericId).FirstOrDefault();
        }
    }
}
