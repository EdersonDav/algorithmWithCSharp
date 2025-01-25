
public class BinarySearch {
    public int search(int[] arrayNumber, int numberToSearch, int smallest, int largest) {
        if (smallest > largest)
            return -1;
        int mid = smallest + (largest - smallest) / 2;
        if (numberToSearch == arrayNumber[mid]) {
            return mid;
        }
        if (numberToSearch > arrayNumber[mid]) {
            return search(arrayNumber, numberToSearch, mid + 1, largest);
        } else if (numberToSearch < arrayNumber[mid]) {
            return search(arrayNumber, numberToSearch, smallest, mid - 1);
        }
        return -1;
    }
}
