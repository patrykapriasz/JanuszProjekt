using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PracaTab
    {
        public PracaTab()
        {
            LogiTab = new HashSet<LogiTab>();
        }

        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public bool? TempDestyl { get; set; }
        public bool? TempRektDol { get; set; }
        public bool? TempRektGora { get; set; }
        public bool? TempSkraplacz { get; set; }
        public bool? Metanol { get; set; }

        public virtual ICollection<LogiTab> LogiTab { get; set; }
    }
}
