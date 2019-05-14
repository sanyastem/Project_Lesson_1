using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;

namespace BL.Services
{
    public class Storage
    {
        public List<User> UsersList { get; set; }

        public Storage() => UsersList = new List<User>();

    }
}
