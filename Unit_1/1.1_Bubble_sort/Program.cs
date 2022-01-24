using System;
namespace BubbleSort {
    class Program {
        static void Main(string[] args) {
            int[] arr = {8, 4, 9, 2, 1, 6};
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++) {
                for (int i = 0; i <= arr.Length - 2; i++) {
                    if (arr[i] > arr[i + 1]) {
                        temp= arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.Read();
        }
    }
}
