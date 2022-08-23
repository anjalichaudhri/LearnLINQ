using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLINQ
{
    internal class OrderBy
    {
        public static IEnumerable<Pet> OrderedPetsByQuerySyntax(IEnumerable<Pet> pets)
        {
            //return (from pet in pets
            //        orderby pet.Name
            //        select pet).ToList();
            
            return pets.OrderBy(p => p.Name);
        }

        public static IEnumerable<Pet> OrderedPetsByDescendingQuerySyntax(IEnumerable<Pet> pets)
        {
            //return from pet in pets
            //       orderby pet?.Name descending
            //       select pet;

            return pets.OrderByDescending(p => p.Name).ToList();
        }

        public static IEnumerable<Pet> OrderedByMultiplePropertiesQuerySyntax(IEnumerable<Pet> pets)
        {
            return from pet in pets
                   orderby pet.Name, pet.Id
                   select pet;
        }

        public static IEnumerable<Pet> OrderedMultiMethodSyntax(IEnumerable<Pet> pets)
        {
            return pets.OrderBy(p => p.Name).ThenByDescending(p => p.Id).ThenBy(p => p.Weight);
        }
    }
}
