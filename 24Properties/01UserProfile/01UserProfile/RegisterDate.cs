using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01UserProfile
{
    internal class RegisterDate
    {
        DateTime Date;
        public RegisterDate()
        {
            Date = DateTime.Now;
        }

        public DateTime Registration
        {
            get { return (Date); }
            //set { Date = value; }          for read only property you cant set property
        }
        public void Message()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Read Only Property");
        }
    }
}
