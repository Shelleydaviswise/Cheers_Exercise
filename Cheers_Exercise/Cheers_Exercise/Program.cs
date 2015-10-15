using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello there! What's your name?");
        string name = Console.ReadLine();
        System.Console.WriteLine("Hi " + name);
            foreach (char letter in name.ToLower())
            {
                if (Char.IsLetter(letter))
                {
                    string mnemonic = "halfnorsemix";
                    string article = "a";
                    if (mnemonic.Contains(letter))
                    {
                        article = "an";
                    }
                    System.Console.WriteLine("Give me " + article + "... " + letter);
                }
            }
        System.Console.WriteLine(name.ToUpper() + " is GRAND");
        System.Console.WriteLine("Press any key to exit.");
        Console.ReadKey();

       

    }
}
}