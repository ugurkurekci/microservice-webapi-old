using Core;
using DataContext.Context;
using System;
using System.Collections.Generic;
using System.Text;
using Users.API.DataAccess.Abstract;
using Users.API.Entities;

namespace Users.API.DataAccess.Concrete
{
    public class UserLogDal : RepositoryBase<UserLog, DatabaseContext>, IUserLogDal
    {
    }
}
