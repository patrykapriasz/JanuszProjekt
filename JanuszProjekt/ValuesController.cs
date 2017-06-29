using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JanuszProjekt
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IColumns _repository;

        public ValuesController(IColumns repo)
        {
            _repository = repo;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "KazmiZPro", "DzanuszNoob", "Sztefan.W" };
        }

        //[HttpGet("[action]")]
        //public JsonResult Columns()
        //{
        //    return Json(_repository.ColumnsData());
        //}

        
    }
}
