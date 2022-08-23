using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLINQ
{
    internal class QuerySyntax
    {
        public static IEnumerable<Pet> IsAnyPetNameRazor(IEnumerable<Pet> pets)
        {
            return (from pet in pets
                   where pet.Name == "Razor"
                   select pet).ToArray();
        }
    }
}
