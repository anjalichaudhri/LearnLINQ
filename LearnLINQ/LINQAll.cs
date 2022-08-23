using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLINQ
{
    class LINQAll
    {
        public static bool AreAllLargerThanOne(IEnumerable<int> numbers)
        {
            return numbers.All(number => number > 1);
        }

        public static bool AreAllNonEmptyNames(IEnumerable<Pet> names)
        {
            return names.All(name => !string.IsNullOrEmpty(name.Name));
        }
    }
}
