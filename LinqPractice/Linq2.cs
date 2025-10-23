using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{
   static class Linq2
    {
       public  static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 4 };
            var res = numbers.Where(n => n > 3).Select(n => n * 2);

            Console.WriteLine("the numbers are");
            foreach(var VrNum in res)
            {
                Console.WriteLine(VrNum);
            }
            Console.ReadLine();
        }
    }
}
