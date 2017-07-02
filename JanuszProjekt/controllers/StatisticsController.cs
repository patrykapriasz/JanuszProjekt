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
    public class StatisticsController : Controller
    {
        private readonly IStatistic _repository;
        private DateTime dateNull = new DateTime(0001, 1, 1, 0, 0, 0);

    public StatisticsController(IStatistic repo)
        {
            _repository = repo;
        }

        [HttpGet("[action]")]
        public JsonResult StatisticsGeneral()
        {
            return Json(_repository.ColumnsStatistics());
        }

        [HttpPost("[action]")]
        public JsonResult StatisticsDay([FromBody] DateTime date)
        {
            return Json(_repository.ColumnsStatistics(date));
        }

        [HttpPost("[action]")]
        public JsonResult StatisticsPeriod([FromBody] Range r)
        {
            var d1 = r.StartTime.Date;
            var d2 = r.EndTime.Date;

            if (r.EndTime == dateNull)
            {
                return Json(_repository.ColumnsStatistics(d1));
            }

            else
            {
                return Json(_repository.ColumnsStatistics(d1, d2));
            }
        }
    // GET: api/values

  }
}
