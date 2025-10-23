using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class Linq5
    {
        static void Main()
        {
            string str;

            Console.WriteLine("Give the string input");
            str= Console.ReadLine();
            Console.WriteLine(str);

            var m = from a in str
                       group a by a into y
                       select y;

            foreach(var x in m)
                Console.WriteLine("Character" + x.Key + x.Count() + "times" );

        }
    }
}
