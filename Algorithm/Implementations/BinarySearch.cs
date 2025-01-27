namespace Implementations;

public class BinarySearch{

    public static int Search(int[] listNumbers, int smallest, int largest, int numberToSearch) {
        if(smallest > largest){
            return -1;
        }

        int mid = smallest + (largest  - smallest) / 2;
        if(numberToSearch == listNumbers[mid]){
            return mid;
        }

        if(numberToSearch > listNumbers[mid]){
            return Search(listNumbers, mid + 1, largest, numberToSearch);
        }else if(numberToSearch < listNumbers[mid]){
            return Search(listNumbers, smallest, mid -1, numberToSearch);
        }

        return -1;
    }
}
