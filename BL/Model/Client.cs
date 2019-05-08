using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Model
{
    enum State_Client
    {
     New = 1,
     Old,
     VIP
    }
    //Женя книга!!!! нюх нюх гау гау
    
    public class Client 
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        private string _login;
        private string _password;
        public string Login
        {
            get
            {
                if (true)
                {
                    
                }
                else
                {
                    
                }
            }; set {
                if (value == "maska для проверки")
                {
                    _password = value;
                }
                else
                {
                    console.WriteLine("govno parol")
                }        
            }; }
        public string Password { get { }; set { }; }

        public void GetFullName()
        {
            Console.WriteLine(LastName+ " " + FirstName);
        }
        
        public bool RegValidPass(string passwordFirst, string passwordSecond)
        {
            return passwordFirst == passwordSecond;
        }

        public bool RegistrationPass(string passwordFirst, string passwordSecond)
        {
            return passwordFirst == passwordSecond;
        }


    }
}