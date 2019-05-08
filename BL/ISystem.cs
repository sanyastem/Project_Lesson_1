using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    interface ISystem<T>
    {
        void Registration(T user);
        void ShowInfoUser(T user);
        string EncryptPassword(string password);
    }
}
