using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ClassObjects
{
    internal class Armstrong
    {
        public void CheckArmstrongNumber(int number)
        {
            int num=10;
            int sum = 0;
            int n = num;
            int power = num.ToString().Length;

            while (n > 0)
            {
                int res = n % 10;
                // sum = sum + (int)Math.Pow(res, power);
                sum = sum + (int)Math.Pow(res, power);
                n = n / 10;
            }

            if (sum == num)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not Armstrong number");
            }
        }
    }
}
