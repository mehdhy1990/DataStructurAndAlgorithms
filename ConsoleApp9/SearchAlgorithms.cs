namespace ConsoleApp9;

public class SearchAlgorithms
{
    public static int BinarySearch(List<int> array, int searchValue)
    {
        var left = 0;
        var right = array.Count -1;
        var middle = (left + right) / 2;
        while (left < right)
        {
            if (searchValue < array[middle])
            {
                right = middle - 1;
                middle = (left + right) / 2;
            }

            else if (searchValue > array[middle])
            {
                left = middle + 1;
                middle = (left + right) / 2;
            }
            else
            {
                return middle;
            }
            
        }
        return -1;
      
    }
}