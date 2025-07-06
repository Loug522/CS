
using LoremIpsum.Infrastructure;

List<int> myList = new();
myList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

/* int myRes = Searches.LinearSearch(myList, 10); */
int myRes = Searches.LinearSearch(list: myList, target: 10);
Console.WriteLine(Searches.TestResult(myRes));

