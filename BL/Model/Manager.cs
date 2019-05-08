using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Model
{

    enum TypeOfManager
    {
        Owner = 1,
        Admin,
        TechSupport, 
        Developer
    }
    public class Manager 
    {
        TypeOfManager TM;
        TM = TypeOfManager.Developer;
        //Ojcze nasz, który jesteś w niebie, niech się święci imię Twoje! Niech przyjdzie królestwo Twoje; niech Twoja wola spełnia się na ziemi, tak jak i w niebie.
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }   
        public char Gender { get; set; }
        private string _login
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
            };
            set 
            {
                if (value == )
                {
                    _password = value
                }
                else
                {
                    Console.WriteLine("Incorrect Login");
                }
            };
        }
        
        private string _passwowrd
        public string Password
        {
            get 
            {
                return "3";
            };
            set 
            {
                return "4";
            }; 
        }

        public bool RegistrationPass(string passwordFirst, string passwordSecond)
        {
            if (passwordFirst == passwordSecond)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Passwords dont similary!");
                return false;
            }

        }

        public void GetFullName()
        {
            Console.WriteLine(" " + FirstName + " " + LastName + " ");
        }


    }
}
