using System;
using System.Collections.Generic;
using System.Text;
using Users.API.Business.Abstract;
using Users.API.DataAccess.Abstract;
using Users.API.Entities;

namespace Users.API.Business.Concrete
{
    public class UserService : IUserService
    {
        readonly IUserDal _userDal;

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User Login(string username, string email, string password)
        {
            return _userDal.GetLogin(username, email, password);
        }

        public void Register(User user)
        {
            _userDal.Add(user);
        }
    }
}
