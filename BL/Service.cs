using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Service : ISystem
    {

        public void Registration(IUserService user)
        {
          
        }

        public void ShowInfoUser(IUserService user)
        {
            user.GetFullName();
        }
    }
}
