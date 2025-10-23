// Three parts of a query operation execute

using LinqPractice;
using System;
using System.Linq;

class Linq1
{
    public static void Main(string[] args)
    {
        int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("Basic structure of LINQ");

        var nQuery=
            from VrNum in n1
            where (VrNum % 2) == 0
            select VrNum;

        Console.WriteLine("Numbers that produces 0");
        foreach(int VrNum in nQuery)
        {
            Console.WriteLine("{0}", VrNum);
        }


    }
}