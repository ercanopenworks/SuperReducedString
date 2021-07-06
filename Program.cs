using System;
using System.Collections.Generic;

namespace SuperReducedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().TrimEnd();

            string result = superReducedString(str);

            Console.WriteLine(result);
        }

        private static string superReducedString(string str)
        {
            Stack<char> resStr = new Stack<char>();
            foreach (var item in str)
            {
                if (resStr.Count > 0)
                {
                    if (item == resStr.Peek())
                    {
                        resStr.Pop();
                    }
                    else
                    {
                        resStr.Push(item);
                    }
                }
                else resStr.Push(item);

            }
            string result = null;
            if (resStr.Count == 0)
            {
                result = "Empty String";
            }
            else
            {
                while(resStr.Count>0)
                {
                    result = resStr.Pop() + result;
                }
            }
            return result;
        }
    }
}
