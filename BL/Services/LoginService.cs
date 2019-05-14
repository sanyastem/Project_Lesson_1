using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;
using BL.Models;

namespace BL.Services
{
    public class LoginService : ILoginService
    {
        public void LogIn()
        {
            throw new NotImplementedException();
        }

        public void LogOut(User user)
        {
            user.CheckLogin = false;
        }
    }
}
