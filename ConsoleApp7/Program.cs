using System.Collections;

List<int> numbers = [10 , 56 , 57, 15 , 96 , 86];
int[] arrayNumbers = [10 , 56 , 57, 15 , 96 , 86];
List<string> fruits = ["apple" , "banana" , "orange" , "pineapple" ];

var filteredNumbers = numbers.CustomWhere(x => x > 5)
    .Take(2).ToList();

Console.ReadKey();

public static class Utilities
{
    public static IEnumerable<object> CustomWhere<T>(this IEnumerable<T> numbers , Func<T,bool> predicate)
    {
        foreach (var number in numbers)
        {
            if (predicate(number))
                yield return number;
        }
    }
}