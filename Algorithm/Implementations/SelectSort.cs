namespace Implementations;

public class SelectSort{
    private static int SearchSmallest(List<int> listNumbers) {
        int smallestIndex = 0;
        for(int i = 0; i < listNumbers.Count; i++ ) {
            if(listNumbers[i] < listNumbers[smallestIndex]){
                smallestIndex = i;
            }
        };
        return smallestIndex;        
    }

    public static List<int> Execute(List<int> listNumbers) {
        int initialIndex = listNumbers.Count;
        List<int> arraySorted = new(initialIndex);

        for(int i = 0; i < initialIndex; i++ ) {
            int smallNumberIndex = SearchSmallest(listNumbers);
            arraySorted.Add(listNumbers[smallNumberIndex]);
            listNumbers.RemoveAt(smallNumberIndex);
        }

        return arraySorted; 
    }
}
