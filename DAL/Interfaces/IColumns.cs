using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL.Interfaces
{
    public interface IColumns
    {
        IEnumerable<KolumnyTab> ColumnsData();
        IEnumerable<KolumnyTab> ColumnsDataFilter(DateTime date);
        IEnumerable<KolumnyTab> ColumnsDataFilter(DateTime dateS, DateTime dateK);
        //List<StatystykaModel> KolumnyStatystyka();

    }
}
