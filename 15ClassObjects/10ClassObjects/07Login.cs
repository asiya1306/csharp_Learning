using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ClassObjects
{
    internal class Login
    {
        string username, password;
        public void getCred(string uname,string pass)
        {
            this.username = uname;
            this.password = pass;
        }
        public void checkCred()
        {
            if(this.username == "admin" && this.password == "12345")
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Enter Valid Credentials");
            }
        }
    }
}
