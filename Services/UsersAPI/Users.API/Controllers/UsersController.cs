using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Users.API.Business.Abstract;
using Users.API.Entities;

namespace Users.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        public void Login(User user)
        {

            _userService.Login(user.Username, user.Email, user.Password);

        }
        [HttpPost("Register")]
        public void Register(User user)
        {

            _userService.Register(user);

        }
    }
}
