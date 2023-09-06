using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01UserProfile
{
    internal class Username
    {
        String uname;
        public String username
        {
            get {  return uname; } 
            set { uname = value; }
        }
        public void Message()
        {
            Console.WriteLine("Read and Write Properties");
        }
    }
}
