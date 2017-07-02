using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using DAL.Models;
using DAL.Support;

namespace DAL.Repo
{
    public class StatisticsRepository: IStatistic
    {
        private readonly patrykapriasz_produkcjaPRSContext _context;

        public StatisticsRepository(patrykapriasz_produkcjaPRSContext context)
        {
            _context = context;
        }
        public IEnumerable<Statistic> ColumnsStatistics()
        {
            return new List<Statistic>(){new Statistic()
            {
                Metanol_avg = _context.KolumnyTab.Select(m=>m.Metanol).Average(),
                Metanol_max = _context.KolumnyTab.Select(m=>m.Metanol).Max(),
                Metanol_min = _context.KolumnyTab.Select(m=>m.Metanol).Min(),
                TempDestyl_avg = _context.KolumnyTab.Select(t=>t.TempDestyl).Average(),
                TempDestyl_max = _context.KolumnyTab.Select(t=>t.TempDestyl).Max(),
                TempDestyl_min = _context.KolumnyTab.Select(t=>t.TempDestyl).Min(),
                TempRektDol_avg = _context.KolumnyTab.Select(t=>t.TempRektDol).Average(),
                TempRektDol_max = _context.KolumnyTab.Select(t=>t.TempRektDol).Max(),
                TempRektDol_min = _context.KolumnyTab.Select(t=>t.TempRektDol).Min(),
                TempRektGora_avg = _context.KolumnyTab.Select(t=>t.TempRektGora).Average(),
                TempRektGora_max = _context.KolumnyTab.Select(t=>t.TempRektGora).Max(),
                TempRektGora_min = _context.KolumnyTab.Select(t=>t.TempRektGora).Min(),
                TempSkraplacz_avg = _context.KolumnyTab.Select(t=>t.TempSkraplacz).Average(),
                TempSkraplacz_max = _context.KolumnyTab.Select(t=>t.TempSkraplacz).Max(),
                TempSkraplacz_min = _context.KolumnyTab.Select(t=>t.TempSkraplacz).Min()
            }};
        }

        public IEnumerable<Statistic> ColumnsStatistics(DateTime date)
        {
            var d1 = date.Date;
            return new List<Statistic>(){new Statistic()
            {
                 Metanol_avg = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Average(m=>m.Metanol),
                Metanol_max = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Max(m=>m.Metanol),
                Metanol_min = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Min(m=>m.Metanol),
                TempDestyl_avg = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Average(t=>t.TempDestyl),
                TempDestyl_max = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Max(t=>t.TempDestyl),
                TempDestyl_min = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Min(t=>t.TempDestyl),
                TempRektDol_avg = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Average(t=>t.TempRektDol),
                TempRektDol_max = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Max(t=>t.TempRektDol),
                TempRektDol_min = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Min(t=>t.TempRektDol),
                TempRektGora_avg = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Average(t=>t.TempRektGora),
                TempRektGora_max = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Max(t=>t.TempRektGora),
                TempRektGora_min = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Min(t=>t.TempRektGora),
                TempSkraplacz_avg = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Average(t=>t.TempSkraplacz),
                TempSkraplacz_max = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Max(t=>t.TempSkraplacz),
                TempSkraplacz_min = _context.KolumnyTab.Where(d=>d.Data.Value.Date==d1).Min(t=>t.TempSkraplacz)
            }};
        }

        public IEnumerable<Statistic> ColumnsStatistics(DateTime dateStart, DateTime dateEnd)
        {
            var d1 = dateStart.Date;
            var d2 = dateEnd.Date;
            return new List<Statistic>(){new Statistic()
            {
                Metanol_avg = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Average(m=>m.Metanol),
                Metanol_max = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Max(m=>m.Metanol),
                Metanol_min = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Min(m=>m.Metanol),
                TempDestyl_avg = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Average(t=>t.TempDestyl),
                TempDestyl_max = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Max(t=>t.TempDestyl),
                TempDestyl_min = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Min(t=>t.TempDestyl),
                TempRektDol_avg = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Average(t=>t.TempRektDol),
                TempRektDol_max = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Max(t=>t.TempRektDol),
                TempRektDol_min = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Min(t=>t.TempRektDol),
                TempRektGora_avg = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Average(t=>t.TempRektGora),
                TempRektGora_max = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Max(t=>t.TempRektGora),
                TempRektGora_min = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Min(t=>t.TempRektGora),
                TempSkraplacz_avg = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Average(t=>t.TempSkraplacz),
                TempSkraplacz_max = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Max(t=>t.TempSkraplacz),
                TempSkraplacz_min = _context.KolumnyTab.Where(d=>d.Data.Value.Date>=d1 && d.Data.Value.Date <=d2).Min(t=>t.TempSkraplacz)
            }};
        }

        public IEnumerable<KolumnyTab> MethanolList(double value)
        {
            var result = _context.KolumnyTab.Where(m => m.Metanol == value).Select(x => x).ToList();
            if (result.Any())
            {
                foreach (var kolumnyTab in result)
                    yield return kolumnyTab;
            }

            else
            {
                result = _context.KolumnyTab.Where(m => m.Metanol > value).Select(x => x).ToList();
                if (result.Any())
                {
                    var x = result.First();
                    yield return x;
                }
                else
                {
                    result = _context.KolumnyTab.Where(m => m.Metanol < value).Select(x => x).ToList();
                    yield return result.First();
                }
            }
        }

        public IEnumerable<KolumnyTab> yieldList(double value)
        {
            double val = value / 480;
            val = Math.Round(val, 2);

            var result = _context.KolumnyTab.Where(m => m.Uzysk == val).Select(x => x).ToList();
            if (result.Any())
            {
                return result;
            }
            else
            {
                result = _context.KolumnyTab.Where(m => m.Uzysk > val).Select(x => x).ToList();
                return result;

            }
        }
    }
}
