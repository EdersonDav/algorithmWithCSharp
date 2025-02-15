namespace Implementations;

public class Recursion{
    public static void InfinityLoop(int number){
        Console.WriteLine(number);
        InfinityLoop(number - 1);
    }

    public static void RegressiveCount(int number){
        Console.WriteLine(number);
        if(number <= 0) return;
        RegressiveCount(number - 1);
    }

    public static double Factorial(int number){
        if(number <= 1) return 1;
        return number * Factorial(number - 1);
    }

    public static void CalSavedMoney(int age, decimal savedMoney){
        if(age <= 0){ 
            Console.WriteLine(savedMoney);
            return;
        }
        savedMoney+= age * 1000;
        CalSavedMoney(age - 1, savedMoney);
    }
}