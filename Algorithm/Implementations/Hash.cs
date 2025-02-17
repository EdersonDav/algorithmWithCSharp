namespace Implementations;

class Hash{
    public static Dictionary<string, double> Book = [];
    public static void RegisterInBook(string name, double value){
        Book[name] = value;
    }

    public static double GetBook(string name){
        return Book[name];
    }
}