// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// int [] arr = new int[8];
// Console.WriteLine(arr [0]);

// int [] arr = {1, 10, 13, 13, 9, 23, 45, 32};
int[] arr= new int [8];
// int[] ar1=new int[array.Length];
for(int i=0; i<arr.Length; i++){
arr[i] = new Random().Next(10,1000);
}
// Console.WriteLine(arr [0]);
// for   (int i = 0; i < arr.Length; i++)
//      {
//         Console.WriteLine(arr[i]);
//     }можно двумя способами)))
for   (int i = 0; i < arr.Length; i++)
     {
        Console.Write(arr[i]+" ");
    }