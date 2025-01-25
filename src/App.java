public class App {
    public static void main(String[] args) throws Exception {
        BinarySearch binarySearch = new BinarySearch();
        int[] arrayNumbers = { 1, 3, 5, 7, 9 };
        System.out.println(binarySearch.search(arrayNumbers, 3, 0, arrayNumbers.length - 1));
    }
}
