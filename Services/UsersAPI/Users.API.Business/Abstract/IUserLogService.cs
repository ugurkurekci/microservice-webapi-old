using System;
using System.Collections.Generic;
using System.Text;
using Users.API.Entities;

namespace Users.API.Business.Abstract
{
    public interface IUserLogService
    {
        void SuccessLog(User user);
        void FailedLog(User user);
    }
}
