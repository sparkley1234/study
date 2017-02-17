using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6
{
    class Program
    {
        static void Main(string[] args)
        {
            string userSentance = string.Empty;
            int totalWords = 0;
            Console.WriteLine("Enter the your sentance");
            userSentance = Console.ReadLine();
            //calling Extension Method WordCount
            totalWords = userSentance.WordCount();
            Console.WriteLine("Total number of words is :" + totalWords);
            Console.ReadLine();
        }
    }

    public static class ExtensionClassName
    {
        public static int WordCount(this string str)
        {
            string[] userString = str.Split(new char[] { ' ', '.', '?' },
                                        StringSplitOptions.RemoveEmptyEntries);
            int wordCount = userString.Length;
            return wordCount;
        }
        
    }
}
