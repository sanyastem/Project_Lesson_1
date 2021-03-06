﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;
using BL.Models;

namespace BL.Services
{
    public class LoginService : ILoginService
    {
        private delegate string ShowBye(User user);
        public void LogIn(List<User> user, User userForCheck)
        {
            if (user.Count == 0||string.IsNullOrEmpty(userForCheck.Login)||string.IsNullOrEmpty(userForCheck.Password))
            {
                userForCheck.CheckLogin = false;
            }

            User userFirst = user.FirstOrDefault(row => userForCheck.Login == row.Login && userForCheck.Password == row.Password);
            if (userFirst!=null)
            {
                userForCheck.CheckLogin = true;
                return;
            }

            userForCheck.CheckLogin = false;
        }

        public void LogOut(User user)
        {
            user.CheckLogin = false;

            ShowBye bye = x => "Goodbye" + x.Profile.LastName;
            bye += x => "Login: " + x.Login;
            
            Console.WriteLine(bye(user));
        }
    }
}
