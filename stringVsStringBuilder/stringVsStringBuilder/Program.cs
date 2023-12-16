using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace stringVsStringBuilder
{
    internal class stringVsStringBuilder
    {

        static void AllString()
        {
            string s1 = "Hello Today is Friday";
            string s2 = s1.Substring(6,5);
            //want to display today
            Console.WriteLine(s2);
            //how to break f=given string , when a space is there.
            s1.Split(' ');
            string[] strs = s1.Split(' ');//array best if foreach
            foreach (string s in strs)
            {
                Console.WriteLine(s);
            }
            //lets is the starting letter is  H because case-sensitive
            bool b1 = s1.StartsWith("H");
            if (b1.ToString() == "True")
                Console.WriteLine("yes / no it starts with H.");
            else 
                Console.WriteLine("NO");

            if (b1.Equals(true))
                Console.WriteLine("yes");
            else Console.WriteLine("NOooooooo");

            //to convert to upper ad lower
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());

            // find index of any character of first occurance
            int n1 = s1.IndexOf("is");
            Console.WriteLine(n1);
            s1.Remove(3, 2);
            string s3 = s1.Insert(6, "Are you");
            Console.WriteLine(s3);
            Console.WriteLine(s3.ToUpper());
            // code to reverse string with the help of array reverse()
            //first convert our string to char array
            char[] chs = s1.ToCharArray(); //here each character is saved in array
            // use foreach
            foreach(char c in chs.Reverse())
            {
                //Console.WriteLine();
                Console.Write(c);
                //Console.WriteLine();
            }
            Console.WriteLine();
            bool b2 = s1.Contains("K");  //checking
        }


        static void Main(string[] args)
        {
            string rname = "";
            for (int i = 0; i < 10; i++)
            {
                rname = rname + i.ToString();
                Console.WriteLine("string class" + rname);//999
            }
            StringBuilder sb = new StringBuilder(10);
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString());
            }
            result = sb.ToString();
            Console.WriteLine(result);
            Console.WriteLine();


        }
    }
}



