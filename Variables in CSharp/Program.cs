using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_in_CSharp
{
    internal class Program
    {
        // Why do we need variables in C#?
        // We need variables to store data

        // THINGS TO KEEP IN MIND:
        // Each variable has a type and a data
        // Every programming has variables but different rules
        // Those rules are called "syntax"
        // In order to set the value to our variable we need to use the assigment operator which is equals "="
               // e.g. int number = 7; 
               // This means our variable number has an integer which equals 7
        static void Main(string[] args)
        {
            // Name rules:
            // In C#, the name can only contain letters,digits and the underscore character "_"
            // e.g. int test = 1; or int _test = 1;
            // No other special characters are allowed
            // The first character must be a letter or underscore, like in the example above
            // C# is case-sensitive with variable names
            // Can't use keywords as variable names in C#

            // Main types of variables: integers,floats,strings,characters, and booleans

            // Integers are any positive or negative whole number (int)
            int a = 100;
            int b = -35;
            int c = 100010110;

            Console.WriteLine("Integers: "+a+", "+b+", "+c);

            // Flaoting point numbers: have decimal values with the suffix "f" (float)
            float n1 = 32.1f;
            float n2 = 42.0f;
            float n3 = 13.3f;

            Console.WriteLine("Floats:"+ n1 + ", " + n2 + ", " + n3);

            // Strings are letters, words or sentences inside of double qoutes
            Console.WriteLine("String: " + "This is called a string and we can type whatever we want.");

            // Characters are one character, withing single qoutes (char)
            char c1 = 'a';
            char c2 = 'b';  
            char c3 = 'c';

            Console.WriteLine("Characters:"+c1 + ", " + c2 + ", " +c3);

            //Booleans can be either true or false (bool)

            bool isCompleted=true;
            bool isNotCompleted = false;

            Console.WriteLine("Completed:" + isCompleted);
            Console.WriteLine("Not Completed:" + isNotCompleted);

            Console.ReadKey();  

        }
    }
}
