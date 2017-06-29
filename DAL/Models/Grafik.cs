using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Grafik
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public int? Zmiana { get; set; }
        public int? Pracownik { get; set; }

        public virtual Pracownicy PracownikNavigation { get; set; }
    }
}
