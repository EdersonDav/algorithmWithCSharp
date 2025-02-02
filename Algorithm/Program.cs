using Implementations;

class Program
{
    static void Main(string[] args)
    {
        RunSelectSort();
    }

    public static void RunBinarySearch(){
        // O(log n)
        int[] arrayNumbers = [1, 3, 5, 7, 9];
        Console.WriteLine(BinarySearch.Search(arrayNumbers, 0, arrayNumbers.Length, 3));
        Console.WriteLine(BinarySearch.Search(arrayNumbers, 0, arrayNumbers.Length - 1, 13));
    }

    public static void RunSelectSort(){
        // O(n x n)
        List<int> arrayNumbers = new([70, 1, 93, 30, 51, 7, 98, 3, 32, 8, 76, 49, 5, 35]);
        Console.WriteLine(string.Join(", ", SelectSort.Sort(arrayNumbers)));
    }
}