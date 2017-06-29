using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repo
{
    public class UserRepository: IUser
    {
        private readonly patrykapriasz_produkcjaPRSContext _context;

        public UserRepository(patrykapriasz_produkcjaPRSContext context)
        {
            _context = context;
        }

        public bool login(string email, string password)
        {
            var pass = _context.UserTable.Where(u => u.UserEmail == email).Select(p => p.UserPassword).FirstOrDefault();
            if (pass == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
