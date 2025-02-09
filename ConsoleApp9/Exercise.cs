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

    public static void CountCharactersPerformant(string input)
    {
        var dict = new Dictionary<char, int>();
        foreach (var item in input)
        {
            if (!dict.ContainsKey(item))
            {
                var code = (int)item;
                if (!(!(code > 47 && code < 58) && // numeric (0-9)
                      !(code > 64 && code < 91) && // upper alpha (A-Z)
                      !(code > 96 && code < 123)))
                {
                    // lower alpha (a-z)
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

    public static bool FrequencyCheck(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length) return false;
        var dict = new Dictionary<int, int>();
        foreach (var item in array1)
        {
            dict[item*item] = item;
        }

        var num = 0;
        foreach (var item in array2)
        {
            if (dict.ContainsKey(item))
            {
                num++;
            }
        }
        if(num == array1.Length)return true;
        return false;

    }

    public static bool AnagramCheck(string name1,string name2)
    {
        var dict = new Dictionary<char, int>();
        foreach (var item in name1)
        {
            if (dict.ContainsKey(item))
            {
                dict[item]++;
                continue;
            }
            dict[item] = 1;
        }

        foreach (var item in name2)
        {
            if (dict.ContainsKey(item))
            {
                dict[item]--;
                if(dict[item] < 0) return false;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}