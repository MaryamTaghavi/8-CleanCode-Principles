using System.Collections;

List<int> numbers = [10 , 56 , 57, 15 , 96 , 86];
int[] arrayNumbers = [10 , 56 , 57, 15 , 96 , 86];
List<string> fruits = ["apple" , "banana" , "orange" , "pineapple" ];

var filteredNumbers = Utilities.CustomWhere(numbers , x => (int)x > 5);

Console.ReadKey();

public static class Utilities
{
    public static List<object> CustomWhere(IEnumerable numbers , Func<object,bool> predicate)
    {
        List<object> result = [];
        foreach (var number in numbers)
        {
            if (predicate(number))
            {
                result.Add(number);
            }
        }

        return result;
    }
}