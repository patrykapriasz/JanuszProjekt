using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JanuszProjekt.controllers
{
    [Route("api/[controller]")]
    public class DashboardController : Controller
    {
        private readonly IProduction _repo;

        public DashboardController(IProduction repository)
        {
            _repo = repository;
        }

        [HttpGet("[action]")]
        public double getTermalTemp()
        {
            return _repo.ThermalTemp();
        }

        [HttpGet("[action]")]
        public double getMethanolStrength()
        {
            return _repo.MethanolStrength();
        }

  }
}
