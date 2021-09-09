using System;
using System.Collections.Generic;
using System.Text;
using Users.API.Entities;


namespace Users.API.Business.Abstract
{
    public interface IUserService
    {
        void Register(User user);
        User Login(string username, string email, string password);
    }
}
