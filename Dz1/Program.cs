class GFG {
 
    static void CountingEvenOdd(int[] arr, int arr_size)
    {
        int even_count = 0;
 
        for (int i = 0; i < arr_size; i++) {
             
            if ((arr[i] & 1) == 1);
            else
                even_count++;
        }
 
        Console.WriteLine(even_count);
    }
 
    public static void Main()
    {
        int[] arr = { 345, 897, 568, 234 };
        int n = arr.Length;
        CountingEvenOdd(arr, n);
    }
}