using System.Text.RegularExpressions;

namespace ConsoleApp9;

class Program
{
    static void Main(string[] args)
    {
        var name = "anagram";
        var name2 = "marganaa";
        Console.WriteLine(Exercise.AnagramCheck(name, name2));
    }
}