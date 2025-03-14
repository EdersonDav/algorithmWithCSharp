﻿using Implementations;

class Program
{
    static void Main(string[] args)
    {
        //RunBinarySearch();
        //RunSelectSort();
        //RunFibonacci();
        //RunRecursion();
        //RunQuickSort();
        //RunHash();
        RunBreadthFirstSearch();
    }

    public static void RunBinarySearch()
    {
        // O(log n)
        int[] arrayNumbers = [1, 3, 5, 7, 9];
        Console.WriteLine(BinarySearch.Execute(arrayNumbers, 0, arrayNumbers.Length, 3));
        Console.WriteLine(BinarySearch.Execute(arrayNumbers, 0, arrayNumbers.Length - 1, 13));
    }

    public static void RunSelectSort()
    {
        // O(n x n)
        List<int> arrayNumbers = new([70, 1, 93, 30, 51, 7, 98, 3, 32, 8, 76, 49, 5, 35]);
        Console.WriteLine(string.Join(", ", SelectSort.Execute(arrayNumbers)));
    }

    public static void RunFibonacci()
    {
        Console.WriteLine(string.Join(", ", Fibonacci.Execute(25)));
        Console.WriteLine(Fibonacci.GetFibonacciByIndex(25));
    }

    public static void RunRecursion()
    {
        //Recursion.InfinityLoop(10);
        //Recursion.RegressiveCount(20);
        //Recursion.CalSavedMoney(1, 0);
        Console.WriteLine(Recursion.Sum([2, 4, 6]));
        
    }

    public static void RunQuickSort(){
        // O(n log n)
        Console.WriteLine(string.Join(", ", QuickSort.Execute([10, 33, 9, 2, 34, 55, 76, 4, 1, 3])));
    }

    public static void RunHash(){
        //O(1)
        Hash.RegisterInBook("apple", 1.23);
        Hash.RegisterInBook("melon", 3.49);

        Console.WriteLine(Hash.GetBook("apple"));
    }

    public static void RunBreadthFirstSearch() {
       // Console.WriteLine(BreadthFirstSearch.SearchAMangoSeller());
        List<List<string>> ways = BreadthFirstSearch.SearchSmallWayStartEnd();
        Console.WriteLine("Ways:");
        List<string> smallWay = ways[0];
        int count = 1;
        foreach (var way in ways)
        {
            if(way.Count < smallWay.Count){
                smallWay = way;
            }
            Console.WriteLine($"{count}º " + string.Join(", ", way));
            count++;

        }

        Console.WriteLine("Small way:");
        Console.WriteLine(string.Join(", ", smallWay));

    }
}