List<int> numbers = [10 , 56 , 57, 15 , 96 , 86];
int[] arrayNumbers = [10 , 56 , 57, 15 , 96 , 86];

List<int> filteredNumbers = Utilities.CustomWhere(numbers , x => x > 5);

List<int> filteredNumbers2 = Utilities.CustomWhere(arrayNumbers , x => x > 6);

Console.ReadKey();

public static class Utilities
{
    public static List<int> CustomWhere(IEnumerable<int> numbers , Func<int,bool> predicate)
    {
        List<int> result = [];
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