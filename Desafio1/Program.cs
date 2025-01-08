using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Phone number0 = new Phone("50 SE", "TCL");
            number0.OpCode = 2;
            Console.WriteLine("Your operator code is: " + number0.OpCode);
            Console.WriteLine("If your operator code is showed, that's right; else: (0)");
            Console.WriteLine("Brand of your phone is: " + number0.brand);
            Console.WriteLine("Model of your phone is: " + number0.model);
            number0.phoneNum = "11323345345";
            Console.WriteLine("Your phone number is: " + number0.phoneNum);
           Console.WriteLine(number0.Call("Martin"));
            Console.ReadKey();


            
        }

    }
}
