using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starPrint
{
    // Program to display the pattern like right angle triangle using an asterisk.
    class Program
    {
        static void Main(string[] args)
        {

            int i, j, rows;
            Console.Write("Input number of rows : ");
            rows = int.Parse(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
               Console.Write("\n");
            }
        
}
    }
}
