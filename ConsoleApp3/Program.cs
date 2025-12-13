List<int> numbers = [10 , 56 , 57, 15 , 96 , 86];
int[] arrayNumbers = [10 , 56 , 57, 15 , 96 , 86];

List<int> filteredNumbers = Utilities.CustomWhere(numbers , new Predicate());
List<int> filteredNumbers2 = Utilities.CustomWhere(arrayNumbers , new Predicate());

Console.ReadKey();

public interface IPredicate
{
    bool IsMatch(int number);

}

public class Predicate : IPredicate
{
    public bool IsMatch(int number)
    {
        return number > 5;
    }
}
public static class Utilities
{
    public static List<int> CustomWhere(IEnumerable<int> numbers , IPredicate predicate)
    {
        List<int> result = [];
        foreach (var number in numbers)
        {
            if (predicate.IsMatch(number))
            {
                result.Add(number);
            }
        }

        return result;
    }
}