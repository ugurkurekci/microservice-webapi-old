using System;
using System.Collections.Generic;
using System.Text;
using Users.API.Business.Abstract;
using Users.API.Entities;

namespace Users.API.Business.Concrete
{
    public class UserLogService : IUserLogService
    {
        public void FailedLog(User user)
        {
            throw new NotImplementedException();
        }

        public void SuccessLog(User user)
        {
            throw new NotImplementedException();
        }
    }
}
