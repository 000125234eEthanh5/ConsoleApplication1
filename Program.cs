using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            stringUtility.StringLibrary clsString = new stringUtility.StringLibrary ();
            Console.WriteLine(clsString.StartsWithUpper("sts"));
            Console.WriteLine(clsString.IsStringPalindrome("sts"));
        }
    }
}
