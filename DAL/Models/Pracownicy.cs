using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Pracownicy
    {
        public Pracownicy()
        {
            Grafik = new HashSet<Grafik>();
        }

        public int Id { get; set; }
        public string Nazwisko { get; set; }
        public string Kontakt { get; set; }

        public virtual ICollection<Grafik> Grafik { get; set; }
    }
}
