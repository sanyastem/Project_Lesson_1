using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;
using BL.Interfaces;

namespace BL.Services
{
    public class RegistrationService
    {
        public User CreateNewUser(string login, string pass, Profile profile) {

            User user = new User() { Login = login, Password = pass, Profile = profile};

            return user;
        }



    }
}
