namespace ConsoleApp9;

public class RecursionConcept
{
    public static void CountDown(int number)
    {
        if (number == 0) return;
        Console.WriteLine(number);
        number--;
        CountDown(number);
        
    } public static int SumRange(int num)
    {
        if(num == 1) return 1;
        return num + SumRange(--num);
    }public static int Factorial(int number)
    {
        if(number ==1) return 1;
        return number * Factorial(--number );
    }
    public static List<int> OddCollector(List<int> numbers, List<int> result)
    {
        if (numbers.Count == 0) return result;
        if (numbers[0] % 2 == 0)
        {
            numbers.Remove(numbers[0]);

            return OddCollector(numbers, result);
        }

        result.Add(numbers[0]);
        numbers.Remove(numbers[0]);
        return OddCollector(numbers, result);
    }
}