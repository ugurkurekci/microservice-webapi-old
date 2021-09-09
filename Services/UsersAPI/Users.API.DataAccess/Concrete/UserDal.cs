using Core;
using DataContext.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Users.API.DataAccess.Abstract;
using Users.API.Entities;

namespace Users.API.DataAccess.Concrete
{
    public class UserDal : RepositoryBase<User, DatabaseContext>, IUserDal
    {
        public User GetLogin(string username, string email, string password)
        {
            using DatabaseContext context = new DatabaseContext();
            return context.User.Where(p => p.Username == username | p.Email == email && p.Password == password).SingleOrDefault();


        }
    }
}
