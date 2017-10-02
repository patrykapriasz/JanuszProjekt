using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using DAL.Support;

namespace DAL.Interfaces
{
    public interface IColumns
    {
        IEnumerable<KolumnyTab> ColumnsData();
        IEnumerable<KolumnyTab> ColumnsDataFilter(DateTime date);
        IEnumerable<KolumnyTab> ColumnsDataFilter(DateTime dateS, DateTime dateK);
        //List<StatystykaModel> KolumnyStatystyka();
        IEnumerable<Methanol> MethanolData();
        IEnumerable<DateTime> MethanolDateTime();
        IEnumerable<double> MethanolStrength();

    }
}
