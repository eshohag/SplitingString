using System;
using System.Text.RegularExpressions;

namespace SplitingString
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "1,2,3";
            var tranMedia = value.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in tranMedia)
            {
                Console.WriteLine(Convert.ToInt32(s));
            }

            string[] configurableFields = Regex.Split("I Love Bangladesh,I hate politics.Test", ",|\\.");
            foreach (var a in configurableFields)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
