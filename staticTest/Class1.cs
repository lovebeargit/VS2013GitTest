using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace staticTest
{
    class Class1
    {
        private string str = "Class1.str";
        private int i = 0;
        static void StringConvert(string str)
        {
            str = "string being converted.";
        }
        static void StringConvert(Class1 c)
        {
            c.str = "string being converted.";
        }
        static void Add(int i)
        {
            i++;
        }
        static void AddWithRef(ref int i)
        {
            i++;
        }
        static void Main()
        {
            int i1 = 10;
            int i2 = 20;
            string str = "str";
            Class1 c = new Class1();
            Add(i1);
            AddWithRef(ref i2);
            Add(c.i);
            StringConvert(str);
            StringConvert(c);
            Console.WriteLine(i1);
            Console.WriteLine(i2);
            Console.WriteLine(c.i);
            Console.WriteLine(str);
            Console.WriteLine(c.str);
        }
    }
}
