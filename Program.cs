using System;
using System.Text;
namespace Phase1Section3._4
{
    class Program
    {
        static void Main()
        {
            DoApp();
        }
        static public void DoApp()
        {

            bool xbool = true;
            byte xbyte = 250;
            sbyte xsbyte = -100;
            char xchar = 'a';
            decimal xdecimal = 87.9M;
            double xdouble = 651.09;
            float xfloat = 465.1f;
            int xint = -8909;
            uint xuint = 91881;
            long xlong = -1313131312;
            ulong xulong = 01919181;
            object xobject = new object();
            short xshort = -19;
            ushort xushort = 19;
            string xstring = "name";

           if (xbool == true && xbyte < 250)
                Console.WriteLine("This expression evaluates to true");
            if (xshort > 6 || xint > -9000)
                Console.WriteLine("This expression evaluates to false");




            //Display results
            Console.WriteLine($"bool: {xbool}");
            Console.WriteLine($"byte: {xbyte}");
            Console.WriteLine($"sbyte: {xsbyte}");
            Console.WriteLine($"char: {xchar}");
            Console.WriteLine($"decimal: {xdecimal}");
            Console.WriteLine($"double: {xdouble}");
            Console.WriteLine($"float: {xfloat}");
            Console.WriteLine($"int: {xint}");
            Console.WriteLine($"uint: {xuint}");
            Console.WriteLine($"long: {xlong}");
            Console.WriteLine($"ulong: {xulong}");
            Console.WriteLine($"object: {xobject}");
            Console.WriteLine($"short: {xshort}");
            Console.WriteLine($"ushort: {xushort}");
            Console.WriteLine($"string: {xstring}");
            Console.WriteLine($"byte: {xbyte}");
           // Console.WriteLine("");




        }

    }
}
