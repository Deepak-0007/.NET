using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1to100_number_print
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n1; i <= n; i++)
                Console.Write(+i+"\t");    
        }
        

    }
}
