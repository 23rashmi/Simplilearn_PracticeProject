using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRefOutTypes
{
    internal class ValueRefOutTypes
    {
        private static int insideVar;

        ////static void Func1(int insideVar)
       //// {
       ////     insideVar = insideVar + 20;
       //////// <summary>
       /// /}
       //////// </summary>
       /////// <param name="insideVar"></param>
        /////static void Func1(ref int insideVar)
        /////{
            
          ////  insideVar = insideVar + 20;
        /////}
        static void Fun1(out int insideVar)
        {
            insideVar = 0;
            insideVar = insideVar + 20;
        }
        static void Main(string[] args)
        {
            int outsideVar = 10;
            Fun1(out outsideVar);
            ////Console.WriteLine(outsideVar);
            ////Console.ReadLine();
            ////Console.WriteLine(insideVar);
            ////Console.ReadLine();

            int x = 10;
            Object y;
            y = x;//boxing
            Console.WriteLine(y);

            Object a = 90;
            int b;
            b = (int)a;//unboxing
            Console.WriteLine(b);


            int v1;
            string str1 = "1000";
            bool xyz = int.TryParse(str1, out v1);
            int.Parse(str1);
            Convert.ToInt32(str1);
            Console.WriteLine(xyz);
            Console.WriteLine(v1);
            ////Console.WriteLine(str1);
            Console.ReadLine();



        }
    }
}



