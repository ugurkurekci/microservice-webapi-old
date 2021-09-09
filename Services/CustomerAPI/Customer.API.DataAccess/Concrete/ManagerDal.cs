using Core;
using Company.API.DataAccess.Abstract;
using Company.API.Models.Concretes;
using DataContext.Context;

namespace Company.API.DataAccess.Concrete
{
    public class ManagerDal : RepositoryBase<Manager, DatabaseContext>, IManagerDal
    {
    }
}
