using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;

namespace BL.Interfaces
{
    interface ILoginService
    {
        void LogIn(List<User> user, User userForCheck);

        void LogOut(User user);
    }
}
