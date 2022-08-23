// See https://aka.ms/new-console-template for more information
using LearnLINQ;

var wordsWithUppercase = new[]
{
    "hey", "WH", "WHaT", "Ha"
};

var marks = new[]
        {
            12, 13, 41, 201, 11, 0, +11
        };

Console.WriteLine(IsAnyWordUpperCase(wordsWithUppercase));
Console.WriteLine(IsAnyWordUpperCase_Linq(wordsWithUppercase));
var orderedWords = OrderedWords(wordsWithUppercase);
foreach(var word in orderedWords) { 
    Console.WriteLine(word);
}
Console.WriteLine($"value larger than 100 exists? : { LINQAny.IsAnyLargerThanValue(marks) }");
Console.WriteLine($"value larger than 100 exists (LINQ)? : {LINQAny.IsLargerThan100LINQ(marks)}");

Console.WriteLine($"even number exists? : {LINQAny.IsAnyEven(marks)}");
Console.WriteLine($"even number exists(LINQ)? : {LINQAny.IsEvenLINQ(marks)}");

/**
 * passing function as parameter in C#
 */
Console.WriteLine($"zero number exists? : {LINQAny.IsAnyZero(marks,IsZero)}");

// lamda expressions are used to create anonymous functions.
static bool IsZero(int mark)
{
    return mark == 0;
}

Console.WriteLine($"negative number exists? : {LINQAny.IsAnyZero(marks, number => number < 0)}");
Console.WriteLine($"Lengh of 2 number exists? : {LINQAny.IsAnyZero(wordsWithUppercase, number => number.Length==2)}");
Console.WriteLine($"Lengh of 2 number exists? : {string.Join(",",LINQAny.WordLongerThanTwoLetters(wordsWithUppercase))}");
var numbers = new int[] {
    10, 13, 11, 2, 3, 4, 5, 6, 7, 6, 8, 2
};

Console.WriteLine($"ordered array odd elements? :{string.Join(",", LINQAny.OrderedOddNumbers(numbers))}");


static bool IsAnyWordUpperCase_Linq(IEnumerable<string> words)
{
    return words.Any(word => word.All(letter => char.IsUpper(letter)));
}
/**
 * order the words in alphabetical order
 */
static string[] OrderedWords(IEnumerable<string> words)
{
    return words.OrderBy(word => word).ToArray();
}

static bool IsAnyWordUpperCase(IEnumerable<string> words)
{
    foreach (string word in words)
    {

        bool isUpperCase = true;
        foreach (var letter in word)
        {
            if (char.IsLower(letter))
            {
                isUpperCase = false;
            }
        }
        if (isUpperCase)
        {
            return true;
        }
    }
    return false;
}


/**
 * deferred Execution int linq improves performance.
 * whaere the Query is mentiioned iterator IsAnyWordUpperCase not materialized there so either materialize iterator by appending ThreadExceptionEventArgs ToArray() orderedWords ToList() function Attribute ThreadExceptionEventArgs end of query.
 * example given below:
 */
var deferredWords = new List<string>
{
    "a", "bb", "ccc", "dddd"
};
// query si not executed here because it is not materialized here. it will be executed where it is needed.
var shortWords = deferredWords.Where(word => word.Length <= 2);

// shortWords.ForEach(Console.WriteLine); // when list is there
// Array.ForEach(shortWords, Console.WriteLine);
// deferredWords.Append("c");
foreach(string word in shortWords)
{
    Console.WriteLine(word);
}

deferredWords.Add("c");

foreach(var word in shortWords)
{
    Console.WriteLine(word);
}

var people = new List<Person>
{
    new Person("John", "UK"),
    new Person("Angel", "USA"),
    new Person("Amy", "USA")
};

/**
 * assume this query has filtered millions and of records, there will be too much overhead
 * so thats why deferred execution is necessary when we need only one thousand reords insead of one
 * million.
 */

var allAmericans = people.Where(person => person.Country == "USA");
var notAllAmericans = allAmericans.Take(1);

var animals = new List<string>
{
    "Zebra","Elephant","Duck", "Monkey", "Dolphin"
};

var animalsNameStartsWithD = animals.Where(a => {
    Console.WriteLine($"checking animal if starts with d: {a}");
    return a.StartsWith("D");

});

foreach(var animal in animalsNameStartsWithD)
{
    Console.WriteLine(animal);
}

/**
 * 1. Method syntax VS 2. Query Syntax
 */
var numbersSmallerThanSeven = numbers.Where(number => number < 7)
    .OrderByDescending(number => number).Distinct();

Console.WriteLine(String.Join(",", numbersSmallerThanSeven));

// query syntax

var numbersMediumerThanSeven = 
    (from number in numbers
    where number < 7
    orderby number
    select number).Distinct();

Console.WriteLine(string.Join(",", numbersMediumerThanSeven));

var petsTry = new List<string>();
var pets = new[]
{
    new Pet(1, "Billey", PetType.Cat, 1.1f),
    new Pet(2, "Bunny", PetType.Fish, 2f),
    new Pet(3, "Rex", PetType.Dog, 3f),
    new Pet(4, "Razor", PetType.Fish, 1.4f)
};

var isAnyPetNamedBruce = pets.Any(p => p.Name == "Rex");
Console.WriteLine(isAnyPetNamedBruce);

var isAnyPetTypeCat = pets.Any(p => p.Type == PetType.Lion);
Console.WriteLine(isAnyPetTypeCat);

var isAnyPetName = petsTry.Any();
Console.WriteLine(isAnyPetName);

// All 
Console.WriteLine($"are All array elements greater than 1? : {LINQAll.AreAllLargerThanOne(numbers)}");
Console.WriteLine($"are All array elements names non empty? : {LINQAll.AreAllNonEmptyNames(pets)}");



