using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01UserProfile
{
    internal class Password
    {
        int pass;
        public int password
        {
            set { pass = value; }
            //get { return (pass); }      for write only property you cant get property
        }
        public void Message()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Write Only Property");
        }
    }
}
