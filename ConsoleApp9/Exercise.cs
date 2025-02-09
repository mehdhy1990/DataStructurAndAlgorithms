using System.Text.RegularExpressions;

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

    public void CountTheCharactersMoreAccureate(string input)
    {
        var name = "111  22 aaa!!";
        Regex regex = new Regex("([a-z0-9])");
        var dict = new Dictionary<char, int>();
        foreach (var item in name)
        {
            if (!dict.ContainsKey(item))
            {
                if (regex.IsMatch(item.ToString()))
                {
                    dict.Add(item, 1);
                }
            }
            else
            {
                dict[item]++;
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}