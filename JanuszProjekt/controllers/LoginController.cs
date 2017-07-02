using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Support;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JanuszProjekt.controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly IUser _repository;

        public LoginController(IUser repo)
        {
            _repository = repo;
        }
    // GET: api/values
        [HttpPost("[action]")]
        public bool loginToApp([FromBody] User user)
        {
            var x= _repository.login(user.UserEmail, user.UserPassword);
            return x;
        }

  }
}
