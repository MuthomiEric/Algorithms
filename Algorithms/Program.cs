// Time complexity = O(n Log n)
// Space complexity = O(n)

using Algorithms.MergeSort;

int[] array = { 7, 2, 5, 0, 3, 8, 4, 9, 1, 6 ,10};

Console.WriteLine("Before Sorting");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

MergeSortAlg.MergeSort(array);

Console.WriteLine("");
Console.WriteLine("After Sorting");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.ReadLine();
