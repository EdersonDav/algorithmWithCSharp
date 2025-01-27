using Implementations;

class Program
{
    static void Main(string[] args)
    { 
        int[] arrayNumbers = [1, 3, 5, 7, 9];
        Console.WriteLine(BinarySearch.Search(arrayNumbers, 0, arrayNumbers.Length, 3));
        Console.WriteLine(BinarySearch.Search(arrayNumbers, 0, arrayNumbers.Length - 1, 13));
    }
}