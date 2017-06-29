using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class LogiTab
    {
        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public int? Urzadzenie { get; set; }
        public int? Czynnosc { get; set; }

        public virtual PracaTab CzynnoscNavigation { get; set; }
        public virtual InstalacjaTab UrzadzenieNavigation { get; set; }
    }
}
