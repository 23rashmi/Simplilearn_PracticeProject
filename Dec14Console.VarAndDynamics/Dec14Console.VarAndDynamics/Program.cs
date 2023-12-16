using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec14Console.VarAndDynamic
{
    public class VarAndDynamic
    {
        public void testingvaranddynamic()
        {
            var s1 = "Hello World";
            int len1 = s1.Length; //length is property class
            Console.WriteLine("var is early bindig with example" + len1);
            dynamic s2 = "hello world";
            int len2 = s2.Length; //unable to display suggestions, because during execution output will come
            Console.WriteLine("dynamic late binding" +len2);


            Console.WriteLine("dynamic"+s2.Length);

        }
        //keys for main svm press tab key 2 times
        static void Main(string[] args)
        {
            VarAndDynamic vd = new VarAndDynamic();
            vd.testingvaranddynamic();
        }
    }
}
