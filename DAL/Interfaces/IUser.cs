using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IUser
    {
        bool login(string email, string password);
    }
}
