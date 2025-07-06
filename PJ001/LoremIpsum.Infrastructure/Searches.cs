
namespace LoremIpsum.Infrastructure;

public class Searches
{
    public static int LinearSearch(List<int> list, int target)
    {
        int targetIndex = 0;
        for (var i = 0; i < list.Last(); i++)
        {
            if (list[i] == target) targetIndex = i;
        }
        return targetIndex;
    }

    public static string TestResult(int result)
    {
        string myRes = "";
        if (result <= 0) myRes = "The target was not found int the list.";
        else myRes = $"The value was found at the index {result}.";
        
        return myRes;
    }
}
