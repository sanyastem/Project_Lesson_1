using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;
using BL.Services;

namespace StartConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage() {
                UsersList = new List<User>() {
                new User() { Login = "Login1", Password = "Pwd1" },
                new User() { Login = "Login2", Password = "Pwd2" },
                new User() { Login = "Login3", Password = "Pwd3" }
                }
            };

            Console.ReadKey();

        }
    }
}
