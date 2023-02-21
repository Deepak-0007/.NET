using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stringfromuserinput
{
    class Program
    {
         static void Main(string[] args)
        {
               Console.WriteLine("Enter String:");

      // Create a string variable and get user input from the keyboard and store it in the variable
      string Name = Console.ReadLine();
      string Name2 = Console.ReadLine();

      // Print the value of the variable (userName), which will display the input value
      Console.WriteLine("Username is: " + Name);
      Console.WriteLine("Username is: " + Name2);
      Console.WriteLine(Name + Name2);
      Console.WriteLine(Name.Length);
      Console.WriteLine(Name.ToUpper());
      Console.WriteLine(Name.ToLower());
      Console.ReadLine();



    }

  }
}

        
    

