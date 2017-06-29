using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Instalacja
    {
        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public double? Kat1 { get; set; }
        public double? Kat2 { get; set; }
        public double? R1 { get; set; }
        public double? R2 { get; set; }
        public double? R3 { get; set; }
        public double? R4 { get; set; }
        public double? R5 { get; set; }
        public double? R6 { get; set; }
        public double? P1 { get; set; }
        public double? P2 { get; set; }
        public double? P3 { get; set; }
        public double? P4 { get; set; }
        public double? BufWyparki { get; set; }
        public double? Wprawa1 { get; set; }
        public double? Wprawa2 { get; set; }
        public double? Wlewa1 { get; set; }
        public double? Wlewa2 { get; set; }
        public double? Gotowy1 { get; set; }
        public double? Gotowy2 { get; set; }
        public double? ZakwasGliceryny1 { get; set; }
        public double? ZakwasGliceryny2 { get; set; }
        public double? Neutralizator1 { get; set; }
        public double? Neutralizator2 { get; set; }
        public double? BuforKolumna { get; set; }
        public double? Wkt { get; set; }
        public double? WodaChlodzenie { get; set; }
        public double? Termal { get; set; }
    }
}
