using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class Linq6
    {
        static void Main()
        {
            string[] Month = { "Jan", "Feb", "Mar", "Apr", "May", "jun", "July", "Aug", "Sept", "Oct", "Nov", "Dec"};
            Console.Write("Name of the Months: ");

            var m = from Jan in Month
                       select Month;

            foreach (var months in m)
             Console.WriteLine(months);

        }
    }

}

