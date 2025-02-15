namespace Implementations;

public class Fibonacci
{
    public static List<int> Execute(int numberLength)
    {
        if (numberLength <= 0) return [];
        if (numberLength == 1) return [0];
        if (numberLength == 2) return [0, 1];

        List<int> fibonacciList = [0, 1];

        for (int i = 2; i < numberLength; i++)
        {
            fibonacciList.Add(fibonacciList[i - 1] + fibonacciList[i - 2]);
        }

        return fibonacciList;
    }

    public static int GetFibonacciByIndex(int n)
    {
        if (n < 0) throw new ArgumentException("O índice não pode ser negativo.");
        if (n == 0) return 0;
        if (n == 1) return 1;

                int a = 0, b = 1;

                for (int i = 2; i < n; i++)
                {
                    int next = a + b;
                    a = b;
                    b = next;
                }

                return b;
    }
}
