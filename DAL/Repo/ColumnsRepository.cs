using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Interfaces;
using DAL.Models;
using DAL.Support;

namespace DAL.Repo
{
    public class ColumnsRepository:IColumns
    {
        private readonly patrykapriasz_produkcjaPRSContext _context;

        public ColumnsRepository(patrykapriasz_produkcjaPRSContext context)
        {
            _context = context;
        }
        public IEnumerable<KolumnyTab> ColumnsData()
        {
            return _context.KolumnyTab.OrderByDescending(m => m.Id);
        }

        public IEnumerable<KolumnyTab> ColumnsDataFilter(DateTime date)
        {
            var list = _context.KolumnyTab.Where(d => d.Data.Value.Date == date.Date).Select(x => x);
            return list;
        }

        public IEnumerable<KolumnyTab> ColumnsDataFilter(DateTime dateS, DateTime dateK)
        {
            var list =
                _context.KolumnyTab.Where(d => d.Data.Value.Date >= dateS.Date && d.Data.Value.Date <= dateK.Date)
                    .Select(x => x)
                    .OrderByDescending(d=>d.Data);
            return list;
        }

        public IEnumerable<Methanol> MethanolData()
        {
            var list = from data in _context.KolumnyTab
                select new Methanol()
                {
                    Date = data.Data.Value.Date,
                    MethanolVal = data.Metanol.Value
                };
            var count = _context.KolumnyTab.Count()-1;
            list.Take(count);
            return list;

        }
    }
}
