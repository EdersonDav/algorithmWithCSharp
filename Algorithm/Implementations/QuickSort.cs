namespace Implementations;

class QuickSort {
    public static List<int> Execute(List<int> arr){
        if(arr.Count < 2){
            return arr;
        }

        int pivot = arr[0];
        List<int> smallThanPivot = [.. arr.Where(x => x < pivot)];
        List<int> biggerThanPivot = [.. arr.Where(x => x > pivot)];

        return [..Execute(smallThanPivot), pivot, ..Execute(biggerThanPivot)];

    }
}