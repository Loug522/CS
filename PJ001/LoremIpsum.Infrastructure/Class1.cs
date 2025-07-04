
namespace LoremIpsum.Infrastructure;

public class Class1
{
    public static int LinearSearch(List<int> list, int target)
    {
        int result = -1;
        for (var i = 0; i < list.Last(); i++)
        {
            if (list[i] == target) result = target;
        }
        return result;
    }

    public static string TestResult(int result)
    {
        string myRes = "";
        if (result < 0) myRes = "The target was not found int the list.";
        else myRes = $"The value {result} was found in the list.";
        
        return myRes;
    }
}
