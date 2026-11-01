using System;
using System.Collections.Generic;
using System.Text;

namespace P1
{
    internal class Concat
    {


        //The concept of concatenation is to join two or more
        //strings together.
        //In C# we can use the + operator to concatenate
        //strings. We can also use the String.Concat()
        //method to concatenate strings.
        //The String.Concat() method is a static
        //method of the String class. It takes two or more
        //strings as parameters and returns a new string that
        //is the concatenation
        //of the input strings.
        internal void ConcatStrings()
        {
            string str1 = "Hello";
            string str2 = "World";
            string str3 = str1 + " " + str2;
            Console.WriteLine(str3);
        }

        internal void ConcatNumbers()
        {
            int n1 = 22;
            int n2 = 33;
            Console.WriteLine(n1 + n2);
        }
        internal void ConcatStrNumbers()
        {
            int n3 = 22;
            string n4 = "33";
            Console.WriteLine(n3 + n4);
        }
    }
}
