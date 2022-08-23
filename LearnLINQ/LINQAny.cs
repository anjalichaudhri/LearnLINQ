using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLINQ
{
    class LINQAny
    {
        // bool isAnyLargerThan100 = isAnyLargerThanValue(marks);

        public static bool IsLargerThan100LINQ(int[] marks)
        {
            return marks.Any(mark => mark > 100);
        }
        public static bool IsAnyLargerThanValue(int[] marks)
        {
            foreach (var mark in marks)
            {
                if(mark > 100)
                {
                    return true;
                }
            }

            return false;
        }

        public static string[] WordLongerThanTwoLetters(IEnumerable<string> words)
        {
            return words.Where(word => word.Length > 2).ToArray();
        }

        public static bool IsEvenLINQ(int[] marks)
        {
            return (marks.Any(mark => mark % 2 == 0));
        }
        public static bool IsAnyEven(int[] marks)
        {
            foreach(var mark in marks)
            {
                if(mark%2 == 0) { return true; }
            }
            return false;
        }

        /**
         * to make the function truly generic define the function of type T and array as IEnumerable<T>
         */
        public static bool IsAnyZero<T>(IEnumerable<T> marks, Func<T, bool> Predicate)
        {
            foreach(var mark in marks)
            {
                if (Predicate(mark))
                {
                    return true;
                }
            }
            return false;
        }

        public static int[] OrderedOddNumbers(IEnumerable<int> numbers)
        {
            return numbers.Where(number => number % 2 != 0)
                .OrderBy(number => number).ToArray();
        }
    }
}
