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
    }
}