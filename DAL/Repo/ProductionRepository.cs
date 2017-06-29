using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repo
{
    public class ProductionRepository : IProduction
    {
        private readonly patrykapriasz_produkcjaPRSContext _context;

        public ProductionRepository(patrykapriasz_produkcjaPRSContext context)
        {
            _context = context;
        }
        public double ThermalTemp()
        {
            var termal = _context.Instalacja.OrderByDescending(d=>d.Id).Select(t => t.Termal).FirstOrDefault();
            if (termal != null) return (double)termal;
            else
            {
                return 0.0;
            }
        }

        public double MethanolStrength()
        {
            var strength = _context.KolumnyTab.OrderByDescending(m => m.Data).Select(r => r.Metanol).FirstOrDefault();
            if (strength != null) return (double) strength;
            else
            {
                return 0.0;
            }
        }
    }
}
