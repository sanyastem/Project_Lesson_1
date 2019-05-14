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
        void LogIn();

        void LogOut(User user);
    }
}
