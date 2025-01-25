
public class BinarySearch {
    public int search(int[] arrayNumber, int numberToSearch, int smallest, int largest) {
        int mid = (int) Math.floor((smallest + largest) / 2);
        if (numberToSearch == arrayNumber[mid]) {
            return mid;
        }
        if (numberToSearch > arrayNumber[mid]) {
            return search(arrayNumber, numberToSearch, mid, largest);
        } else if (numberToSearch < arrayNumber[mid]) {
            return search(arrayNumber, numberToSearch, smallest, mid);
        }
        return -1;
    }
}
