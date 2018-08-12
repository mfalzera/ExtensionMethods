using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            bool result = i.IsGreaterThan(100);
            Console.WriteLine("Result: {0}", result);

            string numberOrNot = "1x234";

            Console.WriteLine("Is {0} numeric? {1}", 
                              numberOrNot, 
                              numberOrNot.IsThisNumeric());
            
            Console.WriteLine();
            Console.WriteLine("<<End of Processing>>");
        }
    }

    // extension methods are a 'special kind of static methods defined in a 
    // static class
    public static class IntExtensions {
        // in the method definition, the first parameter must be an in
        // preceeded by the 'this' modifier
        public static bool IsGreaterThan(this int i, int value) {
            return i > value;
        }
    }

    // string extension to determine if a string is numeric.
    public static class StringExtensions {
        public static bool IsThisNumeric(this string s) {
            return float.TryParse(s, out float output);
        }
    }
}
