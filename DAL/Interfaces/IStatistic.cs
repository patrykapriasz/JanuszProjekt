using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using DAL.Support;

namespace DAL.Interfaces
{
    public interface IStatistic
    {
        IEnumerable<Statistic> ColumnsStatistics();
        IEnumerable<Statistic> ColumnsStatistics(DateTime date);
        IEnumerable<Statistic> ColumnsStatistics(DateTime dateStart, DateTime dateEnd);
        IEnumerable<KolumnyTab> MethanolList(double value);
        IEnumerable<KolumnyTab> yieldList(double value);

    }
}
