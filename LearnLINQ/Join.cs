using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLINQ
{
    internal class Join
    {
        // since name is not unique there will be repetition of name.
        public static IEnumerable<string> JoinByQuerySyntax(IEnumerable<Person> people, IEnumerable<Pet> pets)
        {
            return people.Join(pets,
                pl => pl.Name,
                pt => pt.Name,
                (pl, pt) => pl.Name
                );
        }
    }
}
