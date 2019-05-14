using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;

namespace StartConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User> {
                new User() { Login = "Login1", Password = "Pwd1" },
                new User() { Login = "Login2", Password = "Pwd2" }
            };
        }
    }
}
