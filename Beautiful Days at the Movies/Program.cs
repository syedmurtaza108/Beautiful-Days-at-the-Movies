using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful_Days_at_the_Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);
            Console.WriteLine(result);
        }

        static int beautifulDays(int i, int j, int k)
        {
            int beautifulDays = 0;
            for (int day = i; day <= j; day++)
            {
                int rev = reverse(day);
                if ((Math.Abs(day - rev) % k == 0))
                    beautifulDays++;


            }
            return beautifulDays;

        }

        static int reverse(int a)
        {
            IEnumerable<char> rev = a.ToString().Reverse();
            char[] arr = rev.ToArray();
            string s = "";
            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }
            return int.Parse(s);
        }
    }
}
