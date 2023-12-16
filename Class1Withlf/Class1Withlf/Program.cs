using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1Withlf
{
    internal class Class1Withlf
    {
        public int num1;
        public void IfCondition()
        {
            Console.WriteLine("please enter a number");
            this.num1 = int.Parse(Console.ReadLine());
            if(num1 <= 0)
                Console.WriteLine("number is not valid.");
            else if (num1 > 0 &&  num1 <= 50)
                Console.WriteLine("number is less than than 50.");
            else if (num1 > 25 && num1 <= 75)
                Console.WriteLine("number is good.");
            else 
                Console.WriteLine("number is very good.");
        }



        static void Main(string[] args)
        {
            Class1Withlf cf = new Class1Withlf();
            cf.IfCondition();
            Console.ReadLine();
        }
    }
}
