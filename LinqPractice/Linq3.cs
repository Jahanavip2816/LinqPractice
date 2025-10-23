using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class Linq3
    {
        static void Main()
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            Console.Write("Find number and its square");

            var sqNo = arr1
                .Select(Number => new
                {
                    Number,
                    sqrNo = Number * Number
                })
                .Where(item => item.sqrNo > 20);

            foreach (var a in sqNo)
                Console.WriteLine(a);
        }
        
    }
}
