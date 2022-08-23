using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLINQ
{
    internal class GroupBy
    {
        // grouping the data on the basis of key eg Agegroup like one collection having age 18
        // other collection having age 20
        public static IEnumerable<IGrouping<int, Person>> GroupedPeopleAge(IEnumerable<Person> people)
        {
            return (from person in people
                   group person by person.Age);
        }

        public static Dictionary<int, int> SumOfPeopleGroupedAge(IEnumerable<Person> people)
        {
            return GroupedPeopleAge(people).ToDictionary(
                group => group.Key,
                group => group.Sum(person => person.Age));
        }

        /**
         * first letter of name starts with A
         */
        public static IEnumerable<Person> FirstLetterStartsWithR(IEnumerable<Person> people)
        {
            return from person in people
                   where person.Name.First() == 'A'
                   select person;
        }
    }
}
