using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserTable
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }
}
