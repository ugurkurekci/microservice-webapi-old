using Core;
using Company.API.Models.Concretes;

namespace Company.API.DataAccess.Abstract
{
    public interface ICountryDal : IRepository<Country>
    {
        Country GetCountryByID(int countryId);
        Country GetCountryByName(string countryByName);
        Country GetCountryNumericId(int NumericId);
        Country GetCountryCodeId(string CountryCodeId);
    }
}
