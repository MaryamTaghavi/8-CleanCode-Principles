List<int> numbers = [10 , 56 , 57, 15 , 96 , 86];
int[] arrayNumbers = [10 , 56 , 57, 15 , 96 , 86];

List<int> filteredNumbers = Utilities.CustomWhere(numbers);
List<int> filteredNumbers2 = Utilities.CustomWhere(arrayNumbers);

Console.ReadKey();
public static class Utilities
{
    public static List<int> CustomWhere(List<int> numbers)
    {
        List<int> result = [];
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                result.Add(number);
            }
        }

        return result;
    }
    
    public static List<int> CustomWhere(int[] numbers)
    {
        List<int> result = [];
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                result.Add(number);
            }
        }

        return result;
    }
}