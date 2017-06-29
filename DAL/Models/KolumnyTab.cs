using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KolumnyTab
    {
        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public double? TempDestyl { get; set; }
        public double? TempRektDol { get; set; }
        public double? TempRektGora { get; set; }
        public double? TempSkraplacz { get; set; }
        public double? Metanol { get; set; }
        public int? Uzysk { get; set; }
    }
}
