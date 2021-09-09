using Core;
using System;
using System.Collections.Generic;
using System.Text;
using Users.API.Entities;

namespace Users.API.DataAccess.Abstract
{
    public interface IUserDal : IRepository<User>
    {
        User GetLogin(string username,string email,string password);
    }
}
