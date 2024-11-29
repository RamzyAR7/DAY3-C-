using System;
using System.Text;

namespace DAY3_C_
{
    class Person
    {
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1

            //string UserInput = Console.ReadLine();

            //try
            //{
            //    int Input = int.Parse(UserInput);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("ERROR ==> The input is not in a valid format");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("ERROR ==> The input is too large");
            //}

            //try
            //{
            //    int Input = Convert.ToInt32(UserInput);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("ERROR ==> The input is not in a valid format");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("ERROR ==> The input is too large");
            //}

            /**
             * What is the difference between int.Parse and Convert.ToInt32 when handling null inputs?
             * 
             * If you pass null to int.Parse, it throws an ArgumentNullException because int.Parse expects a non-null string input.
             * If you pass null to Convert.ToInt32, it returns 0 (the default value for an int.
             */

            #endregion

            #region Problem2
            //Console.Write("enrte input in integer: ");
            //int Input;
            //bool Vald = int.TryParse(Console.ReadLine(), out Input);

            //if (Vald)
            //{
            //    Console.WriteLine(Input);
            //}
            //else
            //{
            //    Console.WriteLine("ERROR!!!!!!!");
            //}

            /**
             * Why is TryParse recommended over Parse in user-facing applications?
             * 
             * because it provides a safer and more user-friendly way to handle invalid input
             * 1. Avoids Exceptions
             * 2. Improved User Experience
             * 3. Better Code Readability
             */

            #endregion

            #region Problem3
            //Object obj1 = new Object();
            //obj1 = 22;
            //Console.WriteLine(obj1.GetHashCode());
            //obj1 = "Ramzy";
            //Console.WriteLine(obj1.GetHashCode());
            //obj1 = 2222.55;
            //Console.WriteLine(obj1.GetHashCode());

            /**
             * Explain the real purpose of the GetHashCode() method.
             * 
             *  used to generate a hash code for an object.
             *  A hash code is an integer value that represents the content
             *  or identity of an object in a way that makes it easy and efficient
             *  to compare or store in data structures
             */
            #endregion

            #region Problem4
            //Person p1 = new Person();
            //p1.Name = "ahmed";
            //Person p2 = p1;
            //Console.WriteLine(p2.Name); // ahmed
            //p1.Name = "ramzy";
            //Console.WriteLine(p1.Name); // ramzy

            /**
             * What is the significance of reference equality in .NET? 
             * 
             * reference equality is a way to determine 
             * whether two object references point to the same
             * memory location.
             * Understanding reference equality is significant in scenarios where 
             * you need to identify whether two variables reference the same object, 
             * rather than just having equivalent values.
             * 
             * Implications of Reference Equality:
             * 1- Performance
             * 2- Polymorphism and Overriding
             * 3- Garbage Collection
             */

            #endregion

            #region Problem5
            //string str = "ahmed ramzy";
            //Console.WriteLine(str.GetHashCode());
            //str = str + "Hi Willy";
            //Console.WriteLine(str.GetHashCode());

            /**
             * Why Strings Are Immutable in C# ?
             * 
             * 1. Thread Safety: Strings can't be modified, so they're safe to use in multithreaded environments.
             * 2. Memory Optimization: Immutable strings enable string interning, reusing identical strings to save memory.
             * 3. Predictability: Functions using strings can't accidentally modify the original value, reducing bugs.
             * 4. Hashing Consistency: Immutability ensures a string's hash code never changes, critical for collections like Dictionary.
             * 5. Security: Prevents unintended changes to sensitive data like passwords or URLs.
             */
            #endregion

            #region Problem6
            //StringBuilder StrB = new StringBuilder("ahmed");
            //Console.WriteLine(StrB.GetHashCode());
            //StrB.Append("Hi Willy");
            //Console.WriteLine(StrB.GetHashCode());

            /**
             * How does StringBuilder address the inefficiencies of string concatenation?
             * 
             *by being mutable. 
             *Instead of creating a new string object for every modification,
             *it uses a resizable buffer to perform operations on the same object,
             *reducing memory allocations and improving performance, especially in 
             *repetitive operations like loops.
             * 
             */

            #endregion

            #region Q
            /**
             * Why is StringBuilder faster for large-scale string modifications?
             * 
             *  because it uses a mutable buffer, allowing changes to be made directly to the same memory space.
             *  This avoids the repeated creation and destruction of string objects, which occur with immutable strings.
             *   it minimizes memory allocations and garbage collection overhead, making 
             *   it more efficient for tasks involving frequent or large-scale string changes.
             */
            #endregion

            #region Problem7
            //Console.Write("Enter N1: ");
            //int N1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter N2: ");
            //int N2 = int.Parse(Console.ReadLine());
            //int Sum = N1 + N2;
            //Console.WriteLine("Sum is " + Sum );
            //Console.WriteLine(string.Format("Sum is {0}", Sum));
            //Console.WriteLine($"Sum is {Sum}");

            /**
             * Which string formatting method is most used and why? 
             * 
             * String Interpolation ($) is the most used
             * why
             * Simplicity and readability.
             * Fewer errors.
             * Modern syntax that is intuitive and efficient.
             */
            #endregion

            #region Problem8
             StringBuilder sb = new StringBuilder("ahmed");
            sb.Append(" ramzy");
            Console.WriteLine(sb.ToString());
            sb.Replace(" ramzy", " bassem ");
            Console.WriteLine(sb.ToString());
            sb.Insert(12, " ramzy");
            Console.WriteLine(sb.ToString());
            sb.Remove(6, 7);
            Console.WriteLine(sb.ToString());

            /**
             * Explain how StringBuilder is designed to handle frequent modifications compared to strings?
             * 
             * StringBuilder is designed for efficient string modifications
             * because it is mutable and uses an internal buffer to modify content directly
             * without creating new objects. This avoids the overhead
             * of memory allocation and garbage collection that comes with immutable string operations. It's ideal for scenarios
             * involving frequent concatenations, appends, or changes, as it performs these operations in-place,
             * making it faster and more memory-efficient compared to using string.
             */
            #endregion
        }
    }
}
