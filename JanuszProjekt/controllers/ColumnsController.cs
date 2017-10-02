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
    public class ColumnsController : Controller
    {
        private readonly IColumns _repo;
        DateTime dateNull = new DateTime(0001, 1, 1, 0, 0, 0);

    public ColumnsController(IColumns repository)
        {
            _repo = repository;
        }

        [HttpGet("[action]")]
        public JsonResult ColumnsData()
        {
            return Json(_repo.ColumnsData());
        }

        [HttpPost("[action]")]
        public JsonResult ColumnsDataFilter([FromBody]DateTime date)
        {

            if (date == dateNull)
            {
              return Json(_repo.ColumnsData());
            }
            else
            {
              var d1 = date.Date;
              return Json(_repo.ColumnsDataFilter(d1));
            }

        }

        [HttpPost("[action]")]
        public JsonResult ColumnsDataRange([FromBody] Range p)
        {
            var d1 = p.StartTime.Date;
            var d2 = p.EndTime.Date;
            if (p.EndTime == dateNull)
            {

                return Json(_repo.ColumnsDataFilter(d1));
            }
            else
            {
                return Json(_repo.ColumnsDataFilter(d1,d2));
            }
        }

        [HttpGet("[action]")]
        public JsonResult MethanolChartData()
        {
            return Json(_repo.MethanolData());
        }

        [HttpGet("[action]")]
        public JsonResult MethanolDate()
        {
            return Json(_repo.MethanolDateTime());
        }

        [HttpGet("[action]")]
        public JsonResult MethanolStrength()
        {
            return Json(_repo.MethanolStrength());
        }
    }
}
