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

            try
            {
                foreach (string s in tranMedia)
                {
                    Console.WriteLine(Convert.ToInt32(s));
                }
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            string[] configurableFields = Regex.Split("I Love Bangladesh,I hate politics.Testing!", ",|\\.");
            foreach (var a in configurableFields)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}