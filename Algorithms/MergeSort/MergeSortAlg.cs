namespace Algorithms.MergeSort
{
    internal static class MergeSortAlg
    {
        public static void MergeSort(int[] array)
        {
            int length = array.Length;

            if (length <= 1) return; //base case

            int middle = length / 2;

            int[] leftArray = new int[middle];

            int[] rightArray = new int[length - middle];

            int i = 0; //left array pointer

            int j = 0; //right array pointer

            for (; i < length; i++)
            {
                if (i < middle)
                {
                    leftArray[i] = array[i];
                }
                else
                {
                    rightArray[j] = array[i];

                    j++;
                }
            }
            MergeSort(leftArray);

            MergeSort(rightArray);

            Merge(leftArray, rightArray, array);
        }

        private static void Merge(int[] leftArray, int[] rightArray, int[] array)
        {

            int leftSize = array.Length / 2;

            int rightSize = array.Length - leftSize;

            int mainArr = 0, left = 0, right = 0; //indices

            while (left < leftSize && right < rightSize)
            {
                if (leftArray[left] < rightArray[right])
                {
                    array[mainArr] = leftArray[left];

                    mainArr++;

                    left++;
                }
                else
                {
                    array[mainArr] = rightArray[right];

                    mainArr++;

                    right++;
                }
            }
            while (left < leftSize)
            {
                array[mainArr] = leftArray[left];

                mainArr++;

                left++;
            }
            while (right < rightSize)
            {
                array[mainArr] = rightArray[right];

                mainArr++;

                right++;
            }
        }
    }
}
