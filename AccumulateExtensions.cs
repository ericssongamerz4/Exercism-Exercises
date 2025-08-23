/*
Implement the accumulate operation, which, given a collection and an operation to perform on each element of the collection, 
returns a new collection containing the result of applying that operation to each element of the input collection.

Given the collection of numbers:

1, 2, 3, 4, 5
And the operation:

square a number (x => x * x)
Your code should be able to produce the collection of squares:

1, 4, 9, 16, 25
Check out the test suite to see the expected function signature.

Restrictions
Keep your hands off that collect/map/fmap/whatchamacallit functionality provided by your standard library! Solve this one yourself using other basic tools instead.

To be more specific, you are not allowed to use any of the built-in LINQ methods.

Laziness test
Since accumulate returns an IEnumerable, its execution is deferred until ToList() it is called on it, which is tested with the Accumulate_is_lazy method. 
 
 
 
 
 */




public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        foreach (var item in collection) 
        {
            yield return func(item);                
        }
    }
}



/*
 Explanation
Extension Methods
Extension methods let you "add" new methods to existing types without modifying their source code or creating a derived type. 
They are defined as static methods inside a static class, with the first parameter prefixed by this to specify the type being extended.

Example:

public static class StringExtensions
{
    public static bool IsNullOrEmpty(this string str)
    {
        return string.IsNullOrEmpty(str);
    }
}

// Usage
string s = null;
bool result = s.IsNullOrEmpty(); // cleaner than calling String.IsNullOrEmpty(s)


IEnumerable
IEnumerable<T> represents a sequence of elements that can be iterated with foreach. It provides one method: GetEnumerator(), which returns an IEnumerator<T> to traverse the collection.

Any collection like List<T>, Array, or HashSet<T> implements IEnumerable<T>.

It enables deferred execution (common in LINQ).

Example:

IEnumerable<int> numbers = new List<int> { 1, 2, 3 };
foreach (var n in numbers)
    Console.WriteLine(n);


Key link: Extension methods are often used with IEnumerable<T> (e.g., LINQ’s .Where(), .Select()), enabling fluent and expressive queries on collections.



other resources
https://www.youtube.com/watch?v=H7LhmTGFbhE 
 https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
 
 
 
 */