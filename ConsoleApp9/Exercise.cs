namespace ConsoleApp9;

public class Exercise
{
    public static void CountTheCharacters(string input)
    {
        var dict = new Dictionary<char, int>();
        foreach (var item in input)
        {
            if (!dict.ContainsKey(item))
            {
                dict[item] = 1;
            }
            dict[item]++;
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        };
    }
}