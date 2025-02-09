using System.Text.RegularExpressions;

namespace ConsoleApp9;

class Program
{
    static void Main(string[] args)
    {
        var array1 = new int[] { 1, 2, 3,2 };
        var array2 = new int[] { 4, 1, 9,4 };
      var isOk=  Exercise.FrequencyCheck(array1, array2);
        Console.WriteLine(isOk);
        
    }
}