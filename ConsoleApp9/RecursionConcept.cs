namespace ConsoleApp9;

public class RecursionConcept
{
    public static void CountDown(int number)
    {
        if (number == 0) return;
        Console.WriteLine(number);
        number--;
        CountDown(number);
        
    }
}