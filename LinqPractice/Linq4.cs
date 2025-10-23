using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class Linq4
    {
        static void Main()
        {
            int[] var1 = new int[] { 1, 2, 5, 5, 6, 7, 7, 8, 8, 8, 9, 0, 0, 6, 6, 5, 5, 4, 4, 3, };
            Console.WriteLine("The frequency of the numbers are: ");

            var n = from x in var1
                    group x by x into y
                    select y;

            foreach (var a in n)
                Console.WriteLine(a.Key);
        }
    }
}
