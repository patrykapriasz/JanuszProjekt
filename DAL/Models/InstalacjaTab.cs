using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class InstalacjaTab
    {
        public InstalacjaTab()
        {
            LogiTab = new HashSet<LogiTab>();
        }

        public int Id { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<LogiTab> LogiTab { get; set; }
    }
}
