using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpLanguageFeaturesTest
{
    /// <summary>
    /// INSTRUCTIONS:
    /// 
    /// Follow the directions in the docstring for each question. Do not change the method signature
    /// in any way, including the output type. You may run the provided unit tests in Answers.cs to
    /// check your progress. If you need to create any additional classes, make sure that they are public
    /// and are defined inside the CSharpLanguageFeaturesTest namespace. You may include any private helper
    /// methods you like in Questions.cs.
    /// </summary>
    public static class Questions
    {
        /// <summary>
        /// STRINGS
        /// 
        /// Convert the given string into Title Case. I.e., the first letter of each word
        /// is uppercase, and all other letters are lowercase. Words are separated by spaces.
        /// Punctuation and other whitespace characters do not constitute word boundaries.
        /// </summary>
        public static string Question1(string input)
        {
            return String.Join(" ",
                input.Split(' ').ToList()
                .Select(s => s.ToTitleCase()));
        }
        public static string ToTitleCase(this string s)
        {
                var curString = s.ToLower();
                var charArray = curString.ToCharArray();
                if (charArray.Length > 0)
                charArray[0] = Char.ToUpper(charArray[0]);

                curString = new string(charArray);
            return curString;

              }

        /// <summary>
        /// STRINGS & COLLECTIONS
        /// 
        /// Sort the given list of strings by the number of A's ("a" or "A") it contains,
        /// ascending. Don't worry about breaking ties.
        /// </summary>
        public static List<string> Question2(List<string> input)
        {
            throw new NotImplementedException();
            var list = new List<string>() { catetgory= "asdfhond", catetgory = "This is a test", catetgory = "AAAsa" };
            list.OrderBy(category => category.Count['a', 'A']);
            
           
        }


        /// <summary>
        /// CLASSES
        /// 
        /// Create a new class with three public getter/setter properties named First,
        /// Second, and Third. First should be of type int. Second should be of type string.
        /// Third should have a private setter.
        /// 
        /// In the question method, instantiate this class and return the instantiated object.
        /// </summary>
        public static object Question3()
        {
            return new MyClass();
        }
        public class MyClass
        {

            public string First { get; set; }
            public string Second { get; set; }
            public string Third { get; private set; }
        }


        /// <summary>
        /// CLASSES & INHERITANCE
        /// 
        /// Create a subclass of the class from Question3(). The subclass should have a
        /// parameterless constructor that sets the value of First to 7, and it should have
        /// a method named GetFirstPlusParam() that takes one integer parameter and returns
        /// the value of First plus the value of that parameter.
        /// 
        /// In the question method, instantiate this class and return the instantiated object.
        /// </summary>
        public static object Question4()
        {
            return new YourClass();
        }
        public class YourClass : MyClass
        {
            public YourClass()
            {
                First = 7;

            }

            public int GetFirstPlusParam(int i)
            {
                return First + i;

            }

        }


        /// <summary>
        /// DATETIMES & NULLABLE TYPES & ERROR-HANDLING
        /// 
        /// Given two DateTimes, take whichever DateTime comes later in its respective calendar year
        /// and return a DateTime representing the day after that date, at 3:00 p.m.
        /// 
        /// If the return value would fall out of the possible range of DateTime values, return null.
        /// </summary>
        public static DateTime? Question5(DateTime d1, DateTime d2)
        {
            throw new NotImplementedException();
        }

        public DateTime Question5()
        {
                DateTime d1 = DateTime.Today();
                DateTime d2 = new DateTime(2017, 12, 25);

            if (YourClass.d1 > YourClass.d2)
            {
                d1.AddDays(1);
                DateTime d3 = new DateTime(d1.Year, d1.Month, d1.Day, 15, 0, 0);
                return d3;
            } 
            if (YourClass.d2 > YourClass.d1)
            {
                d2.AddDays(1);
                DateTime d3 = new DateTime(d2.Year, d2.Month, d2.Day, 15, 0, 0);
                return d3;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// MATH & TYPE CONVERSION
        /// 
        /// Given two integers, return the cubed root of the first integer raised to the power of the second integer.
        /// The answer should not be rounded.
        /// </summary>
        public static double Question6(int i1, int i2)
        {
            throw new NotImplementedException();
        }
        public double Question6()
        {
            int i1 = 8;
            int i2 = 5;

            double d2 = (System.Math.Pow(i1, (1 / 3)));
            double d1 = (System.Math.Pow(d2, (i2)));
            return d1;
        }
        /// <summary>
        /// COLLECTION SEARCH
        /// 
        /// Given a list of integer, return the largest odd integer. If there are no odd
        /// integers in the input list, return the smallest possible int.
        /// </summary>
        public static int Question7(List<int> ints)
        {
            throw new NotImplementedException();
            var list = new List<int>() { 1, 13, 4, 25, 33, 21, 24, 26 };

            var oddnumbers = list.Where(num => num % 2 != 0);
            bool isEmpty = !oddnumbers.Any();
            if (isEmpty)
            {
                var smallest = list.Min();
                return smallest;
            }
            else
            {
                var largest = oddnumbers.Max();
                return largest;
            }

        }
    
        /// <summary>
        /// EXTRA CREDIT - ALGORITHM DESIGN
        /// 
        /// Given a list of strings, return all sets of anagrams (a set of words that
        /// contain the same letters in a different order) as lists of strings.
        /// 
        /// Do not allow words to be an anagram of themselves, even if repeated in the
        /// input list. Ignore case. The tests will be case-insensitive and will not
        /// include non-alpha characters. Sort each anagram set in alphabetical order,
        /// and sort the list of anagram sets in alphabetical order, based on the first
        /// word of each set.
        /// </summary>
        public static List<List<string>> Question8(List<string> words)
        {
            throw new NotImplementedException();
        }
    }
}
