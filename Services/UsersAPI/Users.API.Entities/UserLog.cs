using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Users.API.Entities
{
    public class UserLog:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SuccessLogin { get; set; }
        public string FailedLogin { get; set; }
    }
}
